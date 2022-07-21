// See https://aka.ms/new-console-template for more information
using Lesson2;

BankAccount bankAccount1 = new BankAccount(1, 500.00M, BankAccount._AccountType.Debit);
BankAccount bankAccount2 = new BankAccount(1, 100.00M, BankAccount._AccountType.Saving);
Console.WriteLine($"{bankAccount1.Balance} {bankAccount2.Balance} \n");
bankAccount2.TransferMoney(ref bankAccount1, 6000);
bankAccount2.TransferMoney(ref bankAccount1, 200);
Console.WriteLine($"{bankAccount1.Balance} {bankAccount2.Balance} \n");

Console.WriteLine("Введите слово");
string word = Console.ReadLine();
Printer.PrintReverseWord(word);


string path = "C:/Homeworks/Текстовый документ.txt";
using StreamReader sr = new StreamReader(path);
using StreamWriter sw = new StreamWriter(@"C:/Homeworks/Emails.txt");
while (!sr.EndOfStream)
{
    string line = sr.ReadLine();    
    Console.WriteLine(TextFileWork.GetEmail(ref line));
    sw.WriteLine(TextFileWork.GetEmail(ref line));
}

Console.ReadLine();