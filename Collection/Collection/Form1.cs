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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private List<Salaries> collection;
        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int count;
            if (textBox1.Text == "" || (count = Convert.ToInt32(textBox1.Text)) == 0)
            {
                MessageBox.Show("Введите число");
                this.collection = null;
            }
            else
            {
                collection = new List<Salaries>(count);
                Salaries col;
                for (int i = 0; i < count; i++)
                {
                    col = new Salaries();
                    collection.Add(col);
                }
                foreach (Salaries s in collection)
                {
                    listBox1.Items.Add(s.person + " , " + s.salary);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (collection == null || collection.Count == 0)
            {
                MessageBox.Show("Введите число");
            }
            else
            {
                Salaries col = new Salaries();
                collection.Sort(0, collection.Count, col);
                foreach (Salaries s in collection)
                {
                    listBox1.Items.Add(s.person + " , " + s.salary);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();
                if (collection == null || collection.Count == 0)
                {
                    MessageBox.Show("Введите число");
                }
                else
                {
                    Salaries col = new Salaries();
                    collection.Sort();
                    foreach (Salaries s in collection)
                    {
                        listBox1.Items.Add(s.person + " , " + s.salary);
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Ошибка" + ex.Message);
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (collection == null || collection.Count == 0)
            {
                MessageBox.Show("Введите число");
            }
            else
            {
                Form2 form2 = new Form2();
                form2.ShowDialog();
                if (form2.salary > 0)
                {
                    var query_1 = from col in collection
                                  where col.salary == form2.salary
                                  select col;
                    foreach (Salaries s in query_1)
                    {
                        listBox1.Items.Add(s.person + " , " + s.salary);
                    }
                }
                else
                {
                    MessageBox.Show("Вы не написали цену");
                }
            }
        }

        public short salary;
        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (collection == null || collection.Count == 0)
            {
                MessageBox.Show("Введите число");
            }
            else
            {           
                
                var query_2 = from col in collection
                              where col.salary >= 1000
                              select col;
                foreach (Salaries s in query_2)
                {
                    listBox1.Items.Add(s.person + " , " + s.salary);
                }
               
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (collection == null || collection.Count == 0)
            {
                MessageBox.Show("Введите число");
            }
            else
            {

                var query_2 = from col in collection
                              where col.person.Length == 5
                              select col;
                foreach (Salaries s in query_2)
                {
                    listBox1.Items.Add(s.person + " , " + s.salary);
                }

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
