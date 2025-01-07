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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello world");
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            Convert(1);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            Convert(0);
        }

        private void Convert(int s)
        {
            switch (s)
            {
                case 0:
                    Calculate.BackColor = Color.Black;
                    Calculate.ForeColor = Color.White;
                    Calculate.Text = "Calculate";
                    break;
                case 1:
                    Calculate.BackColor = Color.Yellow;
                    Calculate.ForeColor = Color.Red;
                    Calculate.Text = "Calculate";
                    break;
            }
        }
    }
}
