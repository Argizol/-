using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    public class BankAccount
    {
        private static long counter;
        private long _accountNumber;
        private decimal _balance;
        public enum _AccountType
        {
            Debit = 1,
            Credit,
            Saving
        }
        private _AccountType _accountType;

        public BankAccount(long accountNumber)
        {
            AccountNumber = accountNumber;
        }

        public BankAccount(decimal balance)
        {
            Balance = balance;
        }

        public BankAccount(_AccountType accountType)
        {
            AccountType = accountType;
        }

        public BankAccount(long accountNumber, decimal balance, _AccountType accountType) : this(accountNumber)
        {
            Balance = balance;
            AccountType = accountType;
        }

        public decimal TakeMoney(decimal sum)
        {
            if (_balance > sum)
            {
                _balance = _balance - sum;
                return _balance;
            }
            Printer.PrintNoMoney();
            return -1;
        }

        public void TransferMoney(ref BankAccount from, decimal sum)
        {
            if(sum > from._balance)
            {
                Printer.PrintNoMoney();
                return;                
            }
            else
            {
                from.TakeMoney(sum);
            }
            
            this._balance += sum;
        }

        public decimal PushMoney(decimal sum)
        {
            _balance = _balance + sum;
            return _balance + sum;
        }

        public long AccountNumber
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
