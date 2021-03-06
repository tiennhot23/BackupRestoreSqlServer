using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackupRestoreSqlServer
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txUsername.Text.Trim() == "" || txPassword.Text.Trim() == "" || textServerName.Text.Trim() == "")
            {
                MessageBox.Show("Server name, Login name và password không được trống", "", MessageBoxButtons.OK);
                return;
            }

            Program.mlogin = txUsername.Text.Trim();
            Program.password = txPassword.Text.Trim();
            Program.servername = textServerName.Text.Trim();

            // Đăng nhập thất bại
            if (Program.KetNoi() == 0) return;

            Program.conn.Close();

            this.Hide();
            Program.frmMain = new FormMain();
            Program.frmMain.Activate();
            Program.frmMain.ShowDialog();
            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát chương trình", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            textServerName.Text = Program.servername;
            txUsername.Text = Program.mlogin;
            txPassword.Text = Program.password;
        }
    }
}
