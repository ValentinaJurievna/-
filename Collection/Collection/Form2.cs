using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Collection
{
    public partial class Form2 : Form
    {
        public short salary;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                short salary;
                if (this.textBox1.Text != "" && (salary = Convert.ToInt16(this.textBox1.Text)) > 0)
                {
                    this.salary = salary;
                }
                else
                {
                    this.salary = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex.Message);
            }
            this.Close();
        }
    }
}
