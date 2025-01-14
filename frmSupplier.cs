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
    public partial class frmSupplier : Form
    {
        string pid = "";
        SqlConnection sqlCon = null;
        SqlCommand sqlCmd = null;
        string strConn = @"Data Source=DESKTOP-4IQFEGJ;Initial Catalog=miniDB;Integrated Security=True;";

        public frmSupplier()
        {
            InitializeComponent();
        }
        private void frmSupplier_Load(object sender, EventArgs e)
        {
            sqlCon = new SqlConnection(strConn);
            sqlCon.Open();
            sqlCmd = new SqlCommand("SELECT * FROM tbSuppliers", sqlCon);
            SqlDataReader sqlDr = sqlCmd.ExecuteReader();
            DataTable dtPT = new DataTable();
            dtPT.Load(sqlDr);
            showData();
        }

        private void showData()
        {
            sqlCmd = new SqlCommand("SELECT * FROM tbSuppliers", sqlCon);
            SqlDataReader sqlDr = sqlCmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sqlDr);
            dgvShowData.DataSource = dt;
            dgvShowData.Columns[0].HeaderText = "ລະຫັດ";
            dgvShowData.Columns[1].HeaderText = "ຊື່ບໍລິສັດ";
            dgvShowData.Columns[2].HeaderText = "ຊື່ຜູ້ຕິດຕໍ່";
            dgvShowData.Columns[3].HeaderText = "ທີ່ຢູ່";
            dgvShowData.Columns[4].HeaderText = "ເບີໂທຕິດຕໍ່";
            dgvShowData.Columns[5].HeaderText = "ອີເມວ";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string sqlstr = "INSERT INTO tbSuppliers" +
                "(supplier_id,supplier_name,contact_name,address,telephone,email) " +
                "VALUES (@id,@comName,@contName,@addr,@tel,@email)";
            sqlCmd = new SqlCommand(sqlstr, sqlCon);
            sqlCmd.Parameters.AddWithValue("@id", supID.Text);
            sqlCmd.Parameters.AddWithValue("@comName", supName.Text);
            sqlCmd.Parameters.AddWithValue("@contName", contactName.Text);
            sqlCmd.Parameters.AddWithValue("@addr", addr.Text);
            sqlCmd.Parameters.AddWithValue("@tel", phoneNum.Text);
            sqlCmd.Parameters.AddWithValue("@email", email.Text);
            sqlCmd.ExecuteNonQuery();
            showData();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ທ່ານຕ້ອງການລົບຂໍ້ມູນນີ້ຫຼືບໍ່?", "Question",
               MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string sqlstr = "Delete from tbSuppliers where supplier_id='" + pid + "'";
                sqlCmd = new SqlCommand(sqlstr, sqlCon);
                sqlCmd.ExecuteNonQuery();
                showData();
            }
        }

        private void dgvShowData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int cindex = dgvShowData.CurrentRow.Index;
            pid = dgvShowData.Rows[cindex].Cells[0].Value.ToString();
            supID.Text = dgvShowData.Rows[cindex].Cells[0].Value.ToString();
            supName.Text = dgvShowData.Rows[cindex].Cells[1].Value.ToString();
            contactName.Text = dgvShowData.Rows[cindex].Cells[2].Value.ToString();
            addr.Text = dgvShowData.Rows[cindex].Cells[3].Value.ToString();
            phoneNum.Text = dgvShowData.Rows[cindex].Cells[4].Value.ToString();
            email.Text = dgvShowData.Rows[cindex].Cells[5].Value.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string sqlstr = "UPDATE tbSuppliers SET supplier_id=@id,supplier_name=@comName,contact_name=@contName,address=@addr,telephone=@tel,email=@email WHERE supplier_id='" + pid + "'";
            sqlCmd = new SqlCommand(sqlstr, sqlCon);
            sqlCmd.Parameters.AddWithValue("@id", supID.Text);
            sqlCmd.Parameters.AddWithValue("@comName", supName.Text);
            sqlCmd.Parameters.AddWithValue("@contName", contactName.Text);
            sqlCmd.Parameters.AddWithValue("@addr", addr.Text);
            sqlCmd.Parameters.AddWithValue("@tel", phoneNum.Text);
            sqlCmd.Parameters.AddWithValue("@email", email.Text);
            sqlCmd.ExecuteNonQuery();
            showData();
        }
    }
}
