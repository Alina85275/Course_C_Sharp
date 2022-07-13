// Напишите прграмму, уоторая принимает на вход 3 числа и выдает максимальное из этих чисел.
Console.WriteLine("Write a number: ");
string s_a = Console.ReadLine();
Console.WriteLine("Write b number: ");
string s_b = Console.ReadLine();
Console.WriteLine("Write c number: ");
string s_c = Console.ReadLine();

int a = int.Parse(s_a);
int b = int.Parse(s_b);
int c = int.Parse(s_c);
if (a < b)
{
    a = b;
}
if (a < c)
{
    a = c;
    }


    Console.WriteLine(a);

