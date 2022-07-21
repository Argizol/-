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
CodeB codeB = new();
bool isStringCorrect;




do
{
    isStringCorrect = true;
    foreach (char c in str)
    {
        if (!alfabet.Contains(c) && c != ' ')
        {
            isStringCorrect = false;
            break;
        }        
    }
    if (str == string.Empty || !isStringCorrect)
    {
        Console.WriteLine("Вы не ввели строку на русском языке");
        Console.WriteLine("Введите строку на русском языке");
        str = Console.ReadLine().ToLower();
    }        
}
while (str == string.Empty || !isStringCorrect);



//str = codeA.Encoder(str, alfabet);
//Console.WriteLine(str);
//str = codeA.Decoder(str, alfabet);
//Console.WriteLine(str);

str = codeB.Encoder(str, alfabet);
Console.WriteLine(str);
str = codeB.Decoder(str, alfabet);
Console.WriteLine(str);

Console.ReadLine();
