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
    public partial class frmProductType : Form
    {
        string strConnect = @"Data Source=DESKTOP-4IQFEGJ;Initial Catalog=miniDB;Integrated Security=True;";
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataReader reader = null;
        SqlDataAdapter adapter = null;

        public frmProductType()
        {
            InitializeComponent();
            connectionDB_Checking();
            getData();
        }

        private void getData()
        {
            string sql = "SELECT * FROM tbProductType";
            cmd = new SqlCommand(@sql, conn);
            reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dgvShow.DataSource = dt;
            dgvShow.Columns[0].HeaderText = "ລະຫັດປະເພດສິນຄ້າ";
            dgvShow.Columns[1].HeaderText = "ຊື່ປະເພດ";
        }

        private void addData(string id, string name)
        {
            if (id != "" && name != "")
            {
                string sql = "INSERT INTO tbProductType (ptType_ID, ptType_name) VALUES (@Id, @Name)";
                cmd = new SqlCommand(@sql, conn);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.Parameters.AddWithValue("@Name", name);
                try { 
                    cmd.ExecuteNonQuery();
                    getData();
                } catch { }
            }
            else
            {
                MessageBox.Show("ກະລຸນາຕື່ມໃຫ້ຄົບ");
            }
        }

        private void connectionDB_Checking()
        {
            conn = new SqlConnection(strConnect);
            conn.Open();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addData(txtPtTypeID.Text, txtPtTypeName.Text);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE tbProductType SET ptType_name=N'" +
                txtPtTypeName.Text + "' WHERE ptType_ID='" + txtPtTypeID.Text + "'";
            cmd = new SqlCommand(@sql, conn);
            cmd.ExecuteNonQuery();
            getData();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ທ່ານຕ້ອງການລົບຂໍ້ມູນນີ້ບໍ່?", "Question", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string sql = "DELETE FROM tbProductType WHERE ptType_ID='" + txtPtTypeID.Text + "'";
                cmd = new SqlCommand(@sql, conn);
                cmd.ExecuteNonQuery();
                getData();
            }

        }

        private void dgvShow_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int cindex = dgvShow.CurrentRow.Index;
            txtPtTypeID.Text = dgvShow.Rows[cindex].Cells[0].Value.ToString();
            txtPtTypeName.Text = dgvShow.Rows[cindex].Cells[1].Value.ToString();
        }

    }
}
