using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackupRestoreSqlServer
{
    public partial class FormMain : DevExpress.XtraEditors.XtraForm
    {
        private int backupVer = 0;
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            init();
            
        }

        private void init()
        {
            this.databasesTableAdapter.Connection.ConnectionString = Program.connstr;
            this.databasesTableAdapter.Fill(this.dS.databases);
            this.tbAdapterBackupDevice.Connection.ConnectionString = Program.connstr;
            this.tbAdapterBackupDevice.Fill(this.dS.backup_devices);

            onDatabaseClick();

            dateStop.DateTime = DateTime.Now.Date;
            timeStop.Time = DateTime.Now;

            progressBar.Visible = groupDatetime.Visible = cbDelAll.Checked = false;
        }

        private void btnBackup_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.databaseName == "" || Program.deviceName == "") return;

            String strBackup = "BACKUP DATABASE " + Program.databaseName + " TO " + Program.deviceName;
            if (cbDelAll.Checked == true)
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa các bản sao lưu cũ", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    strBackup = strBackup + " WITH INIT ";
                else return;

            startProgressBar();
            if (Program.ExecSqlNonQuery(strBackup, "") != 0)
            {
                endProgressBar();
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu " + Program.databaseName);
                return;
            } else endProgressBar();
            cbDelAll.Checked = false;
            MessageBox.Show("Đã sao lưu cơ sở dữ liệu!");
            onDatabaseClick();
        }    

        private void btnRestore_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.bdsSPSttBackup.Count == 0)
            {
                MessageBox.Show("Chưa có bản sao lưu để phục hồi", "", MessageBoxButtons.OK);
                return;
            }
            if (backupVer == 0)
            {
                MessageBox.Show("Chưa chọn một bản sao lưu để phục hồi", "", MessageBoxButtons.OK);
                return;
            }
            if (Program.conn != null && Program.conn.State == ConnectionState.Open)
                Program.conn.Close(); // đóng kết nối

            if (Program.databaseName == "" || Program.deviceName == "") return;


            if (cbTime.Checked == false)
            {
                String strRestore = "ALTER DATABASE " + Program.databaseName
                    + " SET SINGLE_USER WITH ROLLBACK IMMEDIATE " +
                    " USE TEMPDB \n"
                    + " RESTORE DATABASE " + Program.databaseName
                    + " FROM   " + Program.deviceName + " WITH FILE =  " + backupVer + ", REPLACE "
                    + " ALTER DATABASE  " + Program.databaseName + " SET MULTI_USER";

                if (MessageBox.Show("Bạn có chắc chắn muốn phục hồi database " + Program.databaseName + " về bản backup thứ " + backupVer + "?"
                  , "Cảnh báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    startProgressBar();
                    
                    if (Program.ExecSqlNonQuery(strRestore, "Lỗi phục hồi cơ sở dữ liệu.") == 0)
                    {
                        endProgressBar();
                        MessageBox.Show("Phục hồi dữ liệu thành công", "Thông báo", MessageBoxButtons.OK);
                    }
                    else endProgressBar();
                }
            }
            else
            {
                //Tự động chọn bản backup mới nhất
                bdsSPSttBackup.Position = 0;
                lblBackupNum.Text = ((DataRowView)bdsSPSttBackup[bdsSPSttBackup.Position])["position"].ToString();
                DateTime timeBackup = (DateTime)((DataRowView)bdsSPSttBackup[bdsSPSttBackup.Position])["backup_start_date"];

                DateTime timeStopAt = DateTime.Now;
                try
                {
                    // format lại Ngày giờ người dùng nhập
                    timeStopAt = DateTime.Parse(dateStop.DateTime.Year + "-" + dateStop.DateTime.Month + "-" + dateStop.DateTime.Day + " " +
                    timeStop.Time.Hour + ":" + timeStop.Time.Minute + ":" + timeStop.Time.Second);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể xác định thời gian đã nhập" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
                Console.WriteLine(timeStopAt);
                Console.WriteLine(timeBackup);

                if (timeStopAt > DateTime.Now.Subtract(new TimeSpan(0,1,0)))
                {
                    MessageBox.Show("Thời điểm muốn phục hồi phải trước thời điểm hiện tại ít nhất 1 phút", "", MessageBoxButtons.OK);
                    return;
                }

                if (timeStopAt <= timeBackup)
                {
                    MessageBox.Show("Thời điểm muốn phục hồi phải sau thời điểm bản sao lưu mới nhất", "", MessageBoxButtons.OK);
                    return;
                }

                // backup mới nhất
                backupVer = (int)((DataRowView)bdsSPSttBackup[bdsSPSttBackup.Position])["position"];
                if (MessageBox.Show("Bạn có chắc chắn muốn phục hồi database " + Program.databaseName + " về thời điểm " + timeStopAt.ToString("dd/MM/yyyy hh:mm:ss tt") + "?"
                    , "Cảnh báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {

                    String strRestore = "ALTER DATABASE " + Program.databaseName + " SET SINGLE_USER WITH ROLLBACK IMMEDIATE \n"
                            + " BACKUP LOG " + Program.databaseName + " TO DISK = '" + Program.defaultPath + "DEVICE_" + Program.databaseName + ".trn' WITH INIT, NORECOVERY; \n "
                            + " USE TEMPDB \n"
                            + " RESTORE DATABASE " + Program.databaseName + " FROM  DEVICE_" + Program.databaseName + " WITH FILE =" + backupVer + ", NORECOVERY; \n"
                            + " RESTORE DATABASE " + Program.databaseName + " FROM DISK = '" + Program.defaultPath + "DEVICE_" + Program.databaseName + ".trn' WITH STOPAT= '" + timeStopAt + "' \n"
                            + " ALTER DATABASE  " + Program.databaseName + " SET MULTI_USER ";
                    startProgressBar();
                    if (Program.ExecSqlNonQuery(strRestore, "Lỗi phục hồi cơ sở dữ liệu.") == 0)
                    {
                        endProgressBar();
                        MessageBox.Show("Phục hồi dữ liệu thành công", "Thông báo", MessageBoxButtons.OK);
                    } 
                    else endProgressBar();
                }
            }
        }

        private void cbTime_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cbTime.Checked == true) groupDatetime.Visible = true;
            else groupDatetime.Visible = false;
        }

        private void databasesGridControl_Click(object sender, EventArgs e)
        {
            onDatabaseClick();
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn thoát chương trình", "", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }

        private void btnLogout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn đăng xuất không?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Program.mlogin = "";
                Program.password = "";
                this.Hide();
                Program.frmLogin = new FormDangNhap();
                Program.frmLogin.Activate();
                Program.frmLogin.ShowDialog();
                this.Close();
            }
            else return;
        }

        private void btnDelBackup_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsSPSttBackup.Count == 0)
            {
                MessageBox.Show("Không có bản sao lưu nào để xóa!", "THÔNG BÁO", MessageBoxButtons.OK);
                return;
            }
            if (backupVer == 0)
            {
                MessageBox.Show("Chưa chọn một bản sao lưu để xóa", "", MessageBoxButtons.OK);
                return;
            }
            if (Program.conn != null && Program.conn.State == ConnectionState.Open)
                Program.conn.Close(); // đóng kết nối

            if (Program.databaseName == "" || Program.deviceName == "") return;


            String strDel = "EXEC MSDB.DBO.SP_DELETE_SINGLE_BACKUP " + ((DataRowView)bdsSPSttBackup[bdsSPSttBackup.Position])["backup_set_id"];
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa bản backup thứ " + backupVer + "?", "",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                startProgressBar();

                if (Program.ExecSqlNonQuery(strDel, "Lỗi xóa backup.") == 0)
                {
                    endProgressBar();
                    MessageBox.Show("Xóa backup thành công thành công", "Thông báo", MessageBoxButtons.OK);
                    onDatabaseClick();
                }
                else endProgressBar();
            }
        }

        

        private void btnCreateBackupDevice_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // kiểm tra đường dẫn lưu file backup mặc định có tồn tại chưa
            if (Directory.Exists(Program.defaultPath) == true)
            {
                TaoDevice();
            }
            else
            {
                FolderBrowserDialog browserDialog = new FolderBrowserDialog();
                browserDialog.RootFolder = Environment.SpecialFolder.MyComputer;
                DialogResult result = browserDialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(browserDialog.SelectedPath))
                {
                    // đường dẫn từ desktop bị fail
                    Program.defaultPath = browserDialog.SelectedPath.Replace('\\', '/') + "/";                    
                    TaoDevice();
                }
            }
        }

        private void TaoDevice()
        {
            Console.WriteLine(Program.defaultPath);
            String strTaoDevice = "EXEC sp_addumpdevice 'disk', 'DEVICE_" + Program.databaseName + "', " +
                "'" + Program.defaultPath + "DEVICE_" + Program.databaseName + ".bak' ";
            startProgressBar();
            if (Program.ExecSqlNonQuery(strTaoDevice, "Lỗi tạo device.") == 0)
            {
                endProgressBar();
                Program.deviceName = "DEVICE_" + Program.databaseName;
                MessageBox.Show("Tạo device thành công!", "Thông báo", MessageBoxButtons.OK);
                HideButtonCreateBackupDevice();
            }
            else
            {
                endProgressBar();
                ShowButtonCreateBackupDevice();
            }
        }

        private void STTBACKUPGridControl_Click(object sender, EventArgs e)
        {
            if (bdsSPSttBackup.Count > 0) backupVer = int.Parse(((DataRowView)bdsSPSttBackup.Current)["position"].ToString());
            else backupVer = 0;
            lblBackupNum.Text = backupVer.ToString();
        }

        private void onDatabaseClick()
        {
            if (bdsDatabases.Count > 0)
            {
                Program.databaseName = ((DataRowView)this.bdsDatabases.Current).Row["name"].ToString();
                this.tbAdapterSttBackup.Connection.ConnectionString = Program.connstr;
                this.tbAdapterSttBackup.Fill(this.dS.SP_STT_BACKUP, Program.databaseName);
                lblDatabaseName.Text = Program.databaseName;

                if (bdsSPSttBackup.Count == 0) backupVer = 0;
                else backupVer = int.Parse(((DataRowView)bdsSPSttBackup[0])["position"].ToString());
                lblBackupNum.Text = backupVer.ToString();

                isBackupDeviceExisted();
            }
            else
            {
                ShowButtonCreateBackupDevice();
                btnCreateBackupDevice.Enabled = false;
            }
        }

        private void isBackupDeviceExisted()
        {
            String strDeviceName = "select  COUNT(name) from  sys.backup_devices WHERE name = N'DEVICE_"
               + Program.databaseName + "'";

            Program.myReader = Program.ExecSqlDataReader(strDeviceName);
            if (Program.myReader == null) return;

            Program.myReader.Read();

            if (Program.myReader.GetInt32(0) > 0)
            {
                HideButtonCreateBackupDevice();
                Program.deviceName = "DEVICE_" + Program.databaseName;
            }
            else ShowButtonCreateBackupDevice();
            Program.myReader.Close();

        }

        private void ShowButtonCreateBackupDevice()
        {
            btnBackup.Enabled = btnRestore.Enabled = cbTime.Enabled = btnDelBackup.Enabled = false;
            btnCreateBackupDevice.Enabled = btnThoat.Enabled = true;
        }

        private void HideButtonCreateBackupDevice()
        {
            btnBackup.Enabled = btnRestore.Enabled = cbTime.Enabled = btnThoat.Enabled = btnDelBackup.Enabled = true;
            btnCreateBackupDevice.Enabled = false;
        }

        private void startProgressBar()
        {
            progressBar.Visible = true;
            disableViewWhenInProgress();
            // backgroundWorker1.RunWorkerAsync();
            progressBar.Visible = true;
            for (int i = progressBar.Minimum; i < 70; i++)
            {
                if (i % 10 == 0) Thread.Sleep(200);
                progressBar.Value = i;
            }
        }

        private void endProgressBar()
        {
            for (int i = 70; i <= this.progressBar.Maximum; i++)
            {
                if (i % 10 == 0) Thread.Sleep(200);
                progressBar.Value = i;
            }
            // backgroundWorker1.CancelAsync();
            enableViewWhenProgressComplete();
            progressBar.Visible = false;
        }

        private void disableViewWhenInProgress()
        {
            databasesGridControl.Enabled = STTBACKUPGridControl.Enabled = groupDatetime.Enabled =
                btnBackup.Enabled = btnRestore.Enabled = btnLogout.Enabled = btnThoat.Enabled =
                btnCreateBackupDevice.Enabled = btnDelBackup.Enabled = cbTime.Enabled = false;
        }

        private void enableViewWhenProgressComplete()
        {
            databasesGridControl.Enabled = STTBACKUPGridControl.Enabled = groupDatetime.Enabled = btnLogout.Enabled = true;
            isBackupDeviceExisted();
        }











        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 1; i < 100; i += 1)
            {
                if (backgroundWorker1.CancellationPending)
                {
                    e.Cancel = true;
                } 
                else
                {
                    Thread.Sleep(100);
                    backgroundWorker1.ReportProgress(i);
                }
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar.Visible = false;
        }

    }
}