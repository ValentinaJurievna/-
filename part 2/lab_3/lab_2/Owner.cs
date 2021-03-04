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
    class Owner
    {
        public string Name;
        public string Surname;
        public string MiddleName;
        public string Age;
        public string Sex;
        public string PassportNumber;

        public Owner(string name, string surname, string middleName, string sex, string age, string passportNumber)
        {
            this.Name = name;
            this.Surname = surname;
            this.MiddleName = middleName;
            this.Age = age;
            this.Sex = sex;
            this.PassportNumber = passportNumber;

        }

        

        public override string ToString()
        {
            return this.Name + " " + this.Surname + " " + this.MiddleName + "; " + this.Sex + " пол; " + this.Age + " лет; Номер паспорта: " + this.PassportNumber;
        }
    }

    
}
