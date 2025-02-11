using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Learning
{
    public partial class frmrptProductViewer : Form
    {
        public frmrptProductViewer()
        {
            InitializeComponent();
        }

        private void frmrptProductViewer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dtsProduct.View_Products' table. You can move, or remove it, as needed.
            this.view_ProductsTableAdapter.Fill(this.dtsProduct.View_Products);
            this.reportViewer1.RefreshReport();
        }

        SqlConnection sqlCon = null;
        SqlCommand sqlCmd = null;
        string strConn = @"Data Source=DESKTOP-4IQFEGJ;Initial Catalog=miniDB;Integrated Security=True;";
        private void button1_Click(object sender, EventArgs e)
        {
            sqlCon = new SqlConnection(strConn);
            sqlCon.Open();
            string sqlquery = "";
            if (textBox1.Text != "")
            {
                sqlquery = "where pro_id='" + textBox1.Text + "'";
            }
            sqlCmd = new SqlCommand("SELECT * FROM View_Products " + sqlquery, sqlCon);
            SqlDataReader sqlDr = sqlCmd.ExecuteReader();
            DataTable dtPT = new DataTable();
            dtPT.Load(sqlDr);
            ReportDataSource rtds = new ReportDataSource("DataSet1", dtPT);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rtds);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }

    }
}
