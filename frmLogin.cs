using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Learning
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPwd.Text;

            if (username == "admin" && password == "admin")
            {
                MessageBox.Show("ຍິນດີຕ້ອນຮັບທ່ານເຂົ້າສູ່ລະບົບ");
                frmMainMenu frm = new frmMainMenu();
                frm.Show();
                frm.WindowState = FormWindowState.Maximized;
                this.Hide();
            }
            else
            {
                MessageBox.Show("ຊື່ຜູ້ໃຊ້ລະບົບ ຫຼື ລະຫັດຜ່ານບໍ່ຖືກຕ້ອງ");
            }
        }
    }
}
