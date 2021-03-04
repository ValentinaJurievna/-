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
    public class Account
    {
        public string AccountNumber;
        public string TypeOfDeposit;
        public string AmountOnDeposit;
        public string DateTimeDeposit;
        public string OwnerMakeDeposit;
        public string sms;
        public string banking;


        public Account(string ownerMakeDeposit, string accountNumber, string typeOfDeposit, string amountOnDeposit, string dateTimeDeposit, string SMS, string Banking)
        {
            this.OwnerMakeDeposit = ownerMakeDeposit;
            this.AccountNumber = accountNumber;
            this.TypeOfDeposit = typeOfDeposit;
            this.AmountOnDeposit = amountOnDeposit;
            this.DateTimeDeposit = dateTimeDeposit;
            this.sms = SMS;
            this.banking = Banking;

        }

        public Account() { }

        public override string ToString()
        {
            return this.OwnerMakeDeposit + "; " + this.AccountNumber + " " + this.TypeOfDeposit + " " + this.AmountOnDeposit + "; " + this.DateTimeDeposit + "; " + this.sms + "; " + this.banking;
        }
    }
}
