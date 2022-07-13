// Напишите программу, котрая на вход принимает число и выдает, является ли число четным.
Console.WriteLine("Write a number: ");
string s_a = Console.ReadLine();

int a = int.Parse(s_a);

if (a % 2 == 0)
{
    Console.WriteLine("chetnoe");
}
else
{
    Console.WriteLine("nechetnoe");;
    }

