using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace counter_Framework
{
    public partial class Form1 : Form
    {
        private double leftNumber = 0;
        private double rightNumber = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox_x_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_y_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_operator_Click(object sender, EventArgs e)
        {

        }

        private void button_add_Click(object sender, EventArgs e)
        {
            leftNumber = Convert.ToDouble(textBox_x.Text);
            rightNumber = Convert.ToDouble(textBox_y.Text);
            lbl_operator.Text = "+";
            textBox_outcome.Text = Convert.ToString(leftNumber + rightNumber);
        }

        private void button_sub_Click(object sender, EventArgs e)
        {
            leftNumber = Convert.ToDouble(textBox_x.Text);
            rightNumber = Convert.ToDouble(textBox_y.Text);
            lbl_operator.Text = "-";
            textBox_outcome.Text = Convert.ToString(leftNumber - rightNumber);
        }

        private void button_mult_Click(object sender, EventArgs e)
        {
            leftNumber = Convert.ToDouble(textBox_x.Text);
            rightNumber = Convert.ToDouble(textBox_y.Text);
            lbl_operator.Text = "*";
            textBox_outcome.Text = Convert.ToString(leftNumber * rightNumber);
        }

        private void button_div_Click(object sender, EventArgs e)
        {
            leftNumber = Convert.ToDouble(textBox_x.Text);
            rightNumber = Convert.ToDouble(textBox_y.Text);
            if (leftNumber != 0)
            {
                lbl_operator.Text = "/";
                textBox_outcome.Text = Convert.ToString(leftNumber / rightNumber);
            }
            else
            {
                textBox_outcome.Text = "Wrong";
            }

        }

        private void button_mod_Click(object sender, EventArgs e)
        {
            leftNumber = Convert.ToDouble(textBox_x.Text);
            rightNumber = Convert.ToDouble(textBox_y.Text);
            if (leftNumber != 0)
            {
                lbl_operator.Text = "%";
                textBox_outcome.Text = Convert.ToString(leftNumber % rightNumber);
            }
            else
            {
                textBox_outcome.Text = "Wrong";
            }
        }

        private void button_pow_Click(object sender, EventArgs e)
        {
            leftNumber = Convert.ToDouble(textBox_x.Text);
            rightNumber = Convert.ToDouble(textBox_y.Text);
            lbl_operator.Text = "^";
            textBox_outcome.Text = Convert.ToString(Math.Pow(leftNumber, rightNumber));
        }

        private void button_clean_Click(object sender, EventArgs e)
        {
            textBox_x.Text = "";
            textBox_y.Text = "";
            textBox_outcome.Text = "";
            lbl_operator.Text = "+";
        }
    }
}
