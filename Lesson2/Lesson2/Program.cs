// See https://aka.ms/new-console-template for more information
using Lesson2;

BankAccount bankAccount1 = new BankAccount(1, 500.00M, BankAccount._AccountType.Debit);
Console.WriteLine($"{bankAccount1.AccountNumber}\n{bankAccount1.Balance}\n{bankAccount1.AccountType}\n");
bankAccount1.PushMoney(400);
Console.WriteLine($"{bankAccount1.AccountNumber}\n{bankAccount1.Balance}\n{bankAccount1.AccountType}\n");
bankAccount1.TakeMoney(5000);
bankAccount1.TakeMoney(500);
Console.WriteLine($"{bankAccount1.AccountNumber}\n{bankAccount1.Balance}\n{bankAccount1.AccountType}\n");
Console.ReadLine();