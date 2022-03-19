using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace BackupRestoreSqlServer
{
    static class Program
    {
        public static FormMain frmMain;
        public static FormDangNhap frmLogin;

        public static SqlConnection conn = new SqlConnection();
        public static String connstr;
        public static SqlDataReader myReader;
        public static String servername = "DESKTOP-OB47E9K";
        public static String mlogin = "sa";
        public static String password = "123";
        public static String databaseName = "";
        public static String deviceName = "";

        // đường dẫn mặc định nếu muốn sửa thì sẽ không được--> cần chỉnh sủa code 
        // sao cho khi đổi máy vẫn có thể chạy được
        // Mặc định sẽ mở đường dẫn này, khi tạo device kiểm tra đường dẫn có tồn tại hay không
        // Nếu tồn tại thì lưu trong đường dẫn,  ngược lại mở folder cho người dùng chọn đường dẫn để lưu
        public static String defaultPath = "E:/VisualStudio-workspace/Chuyen_de_cnpm_backup-restore/BackupRestoreSqlServer/Backup_Restore_DB/";

        public static int KetNoi()
        {
            if (Program.conn != null && Program.conn.State == ConnectionState.Open)
                Program.conn.Close();
            try
            {
                Program.connstr = "Data Source=" + Program.servername
                    + ";User ID=" + Program.mlogin
                    + ";password=" + Program.password;
                Program.conn.ConnectionString = Program.connstr;
                Program.conn.Open();
                return 1;
            }

            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại user name và password.\n "
                    + e.Message, "", MessageBoxButtons.OK);
                return 0;
            }
        }

        public static int ExecSqlNonQuery(String strlenh, String errStr)
        {
            conn = new SqlConnection(connstr);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlCommand Sqlcmd = new SqlCommand(strlenh, conn);
            Sqlcmd.CommandType = CommandType.Text;
            Sqlcmd.CommandTimeout = 600;// 10 phut 
            try
            {
                Sqlcmd.ExecuteNonQuery();
                conn.Close();
                return 0;
            }
            catch (SqlException ex)
            {
                conn.Close();
                MessageBox.Show(errStr + "\n" + ex.Message);
                return ex.State;
            }
        }

        public static SqlDataReader ExecSqlDataReader(String strLenh)
        {
            conn.Close();
            SqlDataReader myreader;
            SqlCommand sqlcmd = new SqlCommand(strLenh, conn);
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandTimeout = 600;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader(); return myreader;
            }
            catch (SqlException ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }


        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmLogin = new FormDangNhap();
            Application.Run(frmLogin);
        }
    }
}
