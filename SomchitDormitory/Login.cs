using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SomchitDormitory
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtuser.Text.Length < 1)
            {
                MessageBox.Show("ระบุชื่อผู้ใช้", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (txtuser.Text.Length < 1)
            {
                MessageBox.Show("ระบุรหัสผ่าน", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (new SQL().ExecuteScalar("select count(*) from Users where [UserName]='"+ txtuser.Text +"' and [Password]='" + txtpassword.Text +  "'") > 0)
            {
                this.Hide();
                new MainMenu().Show();
            }
            else
            {
                MessageBox.Show("ชื่อผู้ใช้หรือรหัสผ่านผิด", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtpassword.Clear();
            }
        }
    }
}
