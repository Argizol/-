// See https://aka.ms/new-console-template for more information
using Lesson2;

BankAccount bankAccount1 = new BankAccount();
bankAccount1.AccountNumber = "12313123";
bankAccount1.Balance = 123123.432M;
bankAccount1.AccountType = BankAccount._AccountType.Debit;

Console.Write($"{bankAccount1.AccountNumber}\n{bankAccount1.Balance}\n{bankAccount1.AccountType}");
Console.ReadLine();