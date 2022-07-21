// See https://aka.ms/new-console-template for more information

using Lesson_7;

char[] alfabet = { 
    'а', 'б', 'в', 'г', 'д',
    'е', 'ё', 'ж', 'з', 'и',
    'й', 'к', 'л', 'м', 'н',
    'о', 'п', 'р', 'с', 'т',
    'у', 'ф', 'х', 'ц', 'ч',
    'ш', 'щ', 'ъ', 'ы', 'ь', 
    'э', 'ю', 'я' };

Console.WriteLine("Введите строку на русском языке");
string str = Console.ReadLine().ToLower();

CodeA codeA = new();

if (str == string.Empty)
{
    do
    {
        Console.WriteLine("Вы не ввели строку на русском языке");
        Console.WriteLine("Введите строку на русском языке");
        str = Console.ReadLine();
    }
    while (str == string.Empty);
}

str = codeA.Encoder(str, alfabet);
Console.WriteLine(str);
str = codeA.Decoder(str, alfabet);
Console.WriteLine(str);

Console.ReadLine();
