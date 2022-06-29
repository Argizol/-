// See https://aka.ms/new-console-template for more information
using Lesson2;

BankAccount bankAccount1 = new BankAccount(1);
BankAccount bankAccount2 = new BankAccount(123.555M);
BankAccount bankAccount3 = new BankAccount(BankAccount._AccountType.Saving);

Console.WriteLine($"{bankAccount1.AccountNumber}\n{bankAccount1.Balance}\n{bankAccount1.AccountType}\n");
Console.WriteLine($"{bankAccount2.AccountNumber}\n{bankAccount2.Balance}\n{bankAccount2.AccountType}\n");
Console.WriteLine($"{bankAccount3.AccountNumber}\n{bankAccount3.Balance}\n{bankAccount3.AccountType}\n");
Console.ReadLine();