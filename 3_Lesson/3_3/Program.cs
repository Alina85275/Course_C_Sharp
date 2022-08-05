// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

void Kvadrat (int a)
{
int n = 1;    
while(n <= a)
{   
Console.WriteLine(Math.Pow(n, 2));
n = n+1;
}
}
Kvadrat(5);