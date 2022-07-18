// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

void Metod2(int N)
{
    if (N % 7 == 0 && N % 23 == 0)
        Console.WriteLine("yes");
    else {
        Console.WriteLine("no");
    }
}

Console.WriteLine("Write a number: ");
int n = int.Parse(Console.ReadLine());
Metod2 (n);

