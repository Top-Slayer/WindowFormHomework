using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Learning
{
    public partial class frmLogin : Form
    {
        string strConnect = @"Data Source=DESKTOP-4IQFEGJ;Initial Catalog=miniDB;Integrated Security=True;";
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataReader reader = null;

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
            string sql = "SELECT * FROM tbusers WHERE userName='"+ username +"' AND password_code='"+ password +"'";
            conn  = new SqlConnection(strConnect);
            conn.Open();
            cmd = new SqlCommand(sql, conn);
            reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            conn.Close();

            if (dt.Rows.Count != 0)
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
