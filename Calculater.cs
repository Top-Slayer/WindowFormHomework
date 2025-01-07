using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Learning
{
    public partial class Calculater : Form
    {
        private bool isStillError = true;

        public Calculater()
        {
            InitializeComponent();
        }

        void special_condition(char c)
        {
            if (input_area.Text.Length > 0) 
            {
                input_area.Text += c;
            }
        }

        async Task calculatorProcess()
        {
            try
            {
                DataTable table = new DataTable();
                var result = table.Compute(input_area.Text, "");
                input_area.Text = result.ToString();
            }
            catch (Exception) 
            {
                if (isStillError) { 
                    isStillError = false;
                    input_area.ForeColor = Color.Red;
                    await Task.Delay(2000);
                    input_area.ForeColor = Color.Black;
                    isStillError = true;
                }

            }
        }

        private void button_0_Click(object sender, EventArgs e)
        {
            special_condition('0');
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            input_area.Text += '1';
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            input_area.Text += '2';
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            input_area.Text += '3';
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            input_area.Text += '4';
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            input_area.Text += '5';
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            input_area.Text += '6';
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            input_area.Text += '7';
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            input_area.Text += '8';
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            input_area.Text += '9';
        }

        private void delete_operator_Click(object sender, EventArgs e)
        {
            if (input_area.Text.Length > 0)
            {
                input_area.Text = input_area.Text.Substring(0, input_area.Text.Length - 1);
            }
        }

        private void cancel_operator_Click(object sender, EventArgs e)
        {
            input_area.Text = "";
        }

        private void pass_operator_Click(object sender, EventArgs e)
        {
            special_condition('+');
        }

        private void minus_operator_Click(object sender, EventArgs e)
        {
            special_condition('-');
        }

        private void multiply_operator_Click(object sender, EventArgs e)
        {
            special_condition('*');
        }

        private void divide_operator_Click(object sender, EventArgs e)
        {
            special_condition('/');
        }

        private void equal_operator_Click(object sender, EventArgs e)
        {
            calculatorProcess();
        }

        private void point_operator_Click(object sender, EventArgs e)
        {
            special_condition('.');
        }

        private void button1_Click(object sender, EventArgs e)
        {
            special_condition('%');
        }

        private void Calculater_Load(object sender, EventArgs e)
        {

        }
    }
}
