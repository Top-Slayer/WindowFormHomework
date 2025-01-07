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
    public partial class frmCustomer : Form
    {
        string strConnect = @"Data Source=DESKTOP-4IQFEGJ;Initial Catalog=miniDB;Integrated Security=True;";
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataReader reader = null;
        SqlDataAdapter adapter = null;

        public frmCustomer()
        {
            InitializeComponent();
            connectionDB_Checking();
            getData();

        }
        private void connectionDB_Checking()
        {
            conn = new SqlConnection(strConnect);
            conn.Open();
        }
        private void getData()
        {
            string sql = "SELECT * FROM tbCustomers";
            cmd = new SqlCommand(@sql, conn);
            reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dgvShow.DataSource = dt;
            //dgvShow.Columns[0].HeaderText = "ລະຫັດປະເພດສິນຄ້າ";
            //dgvShow.Columns[1].HeaderText = "ຊື່ປະເພດ";
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO tbCustomers (cust_id, cust_name, cust_Address, telephone) VALUES (@id, @name, @addr, @tel)";
            cmd = new SqlCommand(@sql, conn);
            cmd.Parameters.AddWithValue("@id", txtCust_id.Text);
            cmd.Parameters.AddWithValue("@name", txtCust_name.Text);
            cmd.Parameters.AddWithValue("@addr", txtCust_addr.Text);
            cmd.Parameters.AddWithValue("@tel", txtCust_phone.Text);
            cmd.ExecuteNonQuery();
            getData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE tbCustomers SET cust_name=@name,cust_Address=@addr,telephone=@tel WHERE cust_id=@id";
            cmd = new SqlCommand(@sql, conn);
            cmd.Parameters.AddWithValue("@id", txtCust_id.Text);
            cmd.Parameters.AddWithValue("@name", txtCust_name.Text);
            cmd.Parameters.AddWithValue("@addr", txtCust_addr.Text);
            cmd.Parameters.AddWithValue("@tel", txtCust_phone.Text);
            cmd.ExecuteNonQuery();
            getData();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ທ່ານຕ້ອງການລົບຂໍ້ມູນນີ້ບໍ່?", "Question", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string sql = "DELETE FROM tbCustomers WHERE cust_id='" + txtCust_id.Text + "'";
                cmd = new SqlCommand(@sql, conn);
                cmd.ExecuteNonQuery();
                getData();
            }
        }
        private void dgvShow_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int cindex = dgvShow.CurrentRow.Index;
            txtCust_id.Text = dgvShow.Rows[cindex].Cells[0].Value.ToString();
            txtCust_name.Text = dgvShow.Rows[cindex].Cells[1].Value.ToString();
            txtCust_addr.Text = dgvShow.Rows[cindex].Cells[2].Value.ToString();
            txtCust_phone.Text = dgvShow.Rows[cindex].Cells[3].Value.ToString();
        }
    }
}
