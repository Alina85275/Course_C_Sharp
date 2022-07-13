// Напишите программу, которая на вход принимает число (N), а на выходе показывает все четные числа от 1 до N.
Console.WriteLine("Write N: ");
string s_N = Console.ReadLine();

int N = int.Parse(s_N);
int i = 2;

while (i <= N);
{
    Console.WriteLine(i);
    i += 2;
}


