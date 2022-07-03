// See https://aka.ms/new-console-template for more information
using Lesson2;
using System.Text;

BankAccount bankAccount1 = new BankAccount(1, 500.00M, BankAccount._AccountType.Debit);
BankAccount bankAccount2 = new BankAccount(1, 100.00M, BankAccount._AccountType.Saving);
Console.WriteLine($"{bankAccount1.Balance} {bankAccount2.Balance} \n");
bankAccount2.TransferMoney(ref bankAccount1, 6000);
bankAccount2.TransferMoney(ref bankAccount1, 200);
Console.WriteLine($"{bankAccount1.Balance} {bankAccount2.Balance} \n");

Console.WriteLine("Введите слово");
string word = Console.ReadLine();
Console.WriteLine(Reverse.ReverseWord(word));

Console.ReadLine();