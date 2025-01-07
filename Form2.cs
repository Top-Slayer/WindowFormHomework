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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private string processCal(char o, string n1, string n2)
        {
            switch (o)
            {
                case '+':
                    return (double.Parse(n1) + double.Parse(n2)).ToString();
                case '-':
                    return (double.Parse(n1) - double.Parse(n2)).ToString();
                case '*':
                    return (double.Parse(n1) * double.Parse(n2)).ToString();
                case '/':
                    return (double.Parse(n1) / double.Parse(n2)).ToString();
            }

            return null;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            txtResult.Text = (double.Parse(txtNum1.Text) + double.Parse(txtNum2.Text)).ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            txtResult.Text = (double.Parse(txtNum1.Text) + double.Parse(txtNum2.Text)).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtResult.Text = processCal('+', txtNum1.Text, txtNum2.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtResult.Text = processCal('-', txtNum1.Text, txtNum2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtResult.Text = processCal('*', txtNum1.Text, txtNum2.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtResult.Text = processCal('/', txtNum1.Text, txtNum2.Text);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
