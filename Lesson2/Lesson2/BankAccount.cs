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
        {
            get { return _accountType; }
            set { _accountType = value; }
        }
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

        public override bool Equals(object? obj)
        {
            if (obj is null) return false;

            if (obj is string)
            {
                var str = (string)obj;
                if (!str.Contains($"Номер счета: {AccountNumber}")) return false;
                if (!str.Contains($"Баланс: {Balance}")) return false;
                if (!str.Contains($"Тип счета: {AccountType}")) return false;
                return true;
            }

            if (obj.GetType() != typeof(BankAccount)) return false;

            var other = (BankAccount)obj;

            return AccountNumber == other.AccountNumber
                && Balance == other.Balance
                && AccountType == other.AccountType;
        }

        public static bool operator ==(BankAccount a, BankAccount b) { return (a.AccountNumber == b.AccountNumber) && (a.Balance == b.Balance) && (a.AccountType == b.AccountType); }
        public static bool operator !=(BankAccount a, BankAccount b) { return !(a == b); }

        public override int GetHashCode()
        {
           var hash = 521;

            unchecked
            {
                hash = (hash * 0x18d) ^ AccountNumber.GetHashCode();
                hash = (hash * 0x18d) ^ Balance.GetHashCode();
                hash = (hash * 0x18d) ^ AccountType.GetHashCode();               
            }

            return hash;
        }

        public override string? ToString()
        {
            return $"Номер счета: {AccountNumber}\n" +
                   $"Баланс: {Balance}\n" +
                   $"Тип счета: {AccountType}\n";
        }
    }
}
