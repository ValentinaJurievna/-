using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace lab_2
{
    [Serializable]
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public List<Account> final_list = new List<Account>();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void addOwner_Click(object sender, EventArgs e)
        {

            if (this.Surname.Text == "" || this.Name.Text == "" || this.MiddleName.Text == "" ||
                (this.Male.Checked == false && this.Female.Checked == false) || this.PassportOfOwner.Text == "")
            {
                MessageBox.Show("Введите данные");
            }
            else
            {
                Owner owner = new Owner(this.Surname.Text, this.Name.Text, this.MiddleName.Text,
                                        this.Male.Checked == true ? this.Male.Text : this.Female.Text,
                                        this.AgeOfOwner.Value.ToString(), this.PassportOfOwner.Text);

                listOfOwners.Items.Add(owner);
                OwnerMakeDeposit.Items.Add(owner);
            }

        }

        private void deleteData_Click(object sender, EventArgs e)
        {
            this.Surname.Clear();
            this.Name.Clear();
            this.MiddleName.Clear();
            this.Male.Checked = false;
            this.Female.Checked = false;
            this.AgeOfOwner.Value = 18;
            this.PassportOfOwner.Clear();
        }

        private void deleteOwners_Click(object sender, EventArgs e)
        {
            listOfOwners.Items.Clear();
        }

        private void addAccount_Click(object sender, EventArgs e)
        {
            Account account = new Account(this.OwnerMakeDeposit.SelectedItem.ToString(), this.AccountNumber.Text,
                                          this.TypeOfDeposit.Text, this.AmountOnDeposit.Text, this.DateTimeDeposit.Text,
                                          this.sms.Checked == true ? this.sms.Text : null, this.banking.Checked == true ? this.banking.Text : null);




            if (OwnerMakeDeposit.CheckedItems.Count > 1)
            {
                MessageBox.Show("Вы выбрали слишком много владельцев");
                this.OwnerMakeDeposit.ClearSelected();
            }

            else
            {
                final_Information.Items.Add(account);
            }




        }
        public List<Account> list = new List<Account>();
        private void writeToFile_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.FileName = "serialization.xml";
            saveFileDialog1.InitialDirectory = "D:\\2 курс\\2 сем\\ООП\\Programming\\part 2\\lab_2";
            saveFileDialog1.ShowDialog();

            Account account = new Account(this.OwnerMakeDeposit.SelectedItem.ToString(), this.AccountNumber.Text,
                                          this.TypeOfDeposit.Text, this.AmountOnDeposit.Text, this.DateTimeDeposit.Text,
                                          this.sms.Checked == true ? this.sms.Text : null, this.banking.Checked == true ? this.banking.Text : null);
            list.Add(account);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Account>));
            using (FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(fs, list);
            }
        }

        private void readFromFile_Click(object sender, EventArgs e)
        {
            /*OpenFileDialog openFileDialog1 = new OpenFileDialog();
            
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            string filename = openFileDialog1.FileName;
   
            string fileText = System.IO.File.ReadAllText(filename);
            final_Information.Text = fileText;
            final_Information.Items.Add(fileText);
            MessageBox.Show("Файл открыт");*/

            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.FileName = "serialization.xml";
                openFileDialog1.InitialDirectory = "D:\\2 курс\\2 сем\\ООП\\Programming\\part 2\\lab_2";
                openFileDialog1.ShowDialog();

                List<Account> lst;
                using (FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Account>));
                    lst = (List<Account>)xmlSerializer.Deserialize(fs);
                                  
                }
               
                foreach (Account a in lst)
                {
                    final_list.Add(a);
                    this.final_Information.Items.Add(a);
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("error:" + ex.Message);
            }

        }

        private void aboutProgram_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made by Valentina Ivantsova\nAll rights reserved");
        }
    }
}
