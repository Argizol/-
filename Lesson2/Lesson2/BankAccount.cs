using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    public class BankAccount
    {
        private string _accountNumber;
        private decimal _balance;
        public enum _AccountType
        {
            Debit,
            Credit,
            Saving
        }
        private _AccountType _accountType;

        public string AccountNumber
        { 
            get { return _accountNumber; } 
            set { _accountNumber = value; }
        }

        public decimal Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }

        public _AccountType AccountType
        { get { return _accountType;}
          set { _accountType = value; }
        }
    }
}
