using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Learning
{
    public partial class Form3 : Form
    {
        private short select = 0;

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("d MMMM yyyy");  comboBox1.Items.Add("d MM yyyy");
            comboBox1.Items.Add("MMMM dd, yyyy");  comboBox1.Items.Add("dd-MM-yy");
            comboBox1.Items.Add("dd/MM/yyyy");
            comboBox1.Items.Add("dddd, MMMM dd ");  comboBox1.Items.Add("hh.mm.ss");
            comboBox1.Items.Add("hh.mm");
            comboBox1.Items.Add("d");
            comboBox1.SelectedIndex = 0;
        }

        private void Prcoess_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            DateTimeFormatInfo dtfInfo;
            string DateStyle = "";

            if (radioButton2.Checked)
            {
                dtfInfo = DateTimeFormatInfo.InvariantInfo;
            }
            else
            {
                dtfInfo = DateTimeFormatInfo.CurrentInfo;
            }
            DateStyle = comboBox1.Text;
            label3.Text = dt.ToString(DateStyle, dtfInfo);
        }
    }
}
