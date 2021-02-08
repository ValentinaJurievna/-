using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public string action;
        public string number_1;
        public bool number_2;
        public Form1()
        {
            number_2 = false;
            InitializeComponent();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int length = textBox2.Text.Length - 1;
            string text = textBox2.Text;
            textBox2.Clear();
            for (int i = 0; i < length; i++)
            {
                textBox2.Text = textBox2.Text + text[i];
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double result;
            result = Math.Sin(Convert.ToDouble(this.textBox2.Text));
            textBox1.Text = result.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            double result;
            result = Math.Cos(Convert.ToDouble(this.textBox2.Text));
            textBox1.Text = result.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            double result;
            result = Math.Tan(Convert.ToDouble(this.textBox2.Text));
            textBox1.Text = result.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            double result = Math.Pow(Convert.ToDouble(textBox2.Text), 1.0/3.0);
            textBox1.Text = result.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            double result = Math.Sqrt(Convert.ToDouble(textBox2.Text));
            textBox1.Text = result.ToString();
        }

       
        private void button7_Click_1(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            action = b.Text;
            number_1 = textBox1.Text;
            number_2 = true;

        }

        private void button13_Click(object sender, EventArgs e)
        {
            double result = Math.Pow(Convert.ToDouble(textBox2.Text), 2);
            textBox1.Text = result.ToString();
        }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            double res_1, res_2, res;
            res = 0;
            res_1 = Convert.ToDouble(number_1);
            res_2 = Convert.ToDouble(textBox1.Text);
            if (action == "+")
            {
                res = res_1 + res_2;
            }
            if (action == "-")
            {
                res = res_1 - res_2;
            }
            if (action == "×")
            {
                res = res_1 * res_2;
            }
            if (action == "/")
            {
                res = res_1 / res_2;
            }

            action = "=";
            number_2 = true;
            textBox1.Text = res.ToString();
        }

        private void button7_Click_2(object sender, EventArgs e)
        {

        }
    }
}
