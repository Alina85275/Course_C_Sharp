//Задача 3: Напишите программу, которая принимает на
//вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
void Kub (int a)
{
int n = 1;    
while(n <= a)
{   
Console.WriteLine(Math.Pow(n, 3));
n = n+1;
}
}
Kub(3);
