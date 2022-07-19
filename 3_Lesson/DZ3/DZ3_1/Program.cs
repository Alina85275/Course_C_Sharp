// Задача 1: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

void Kvadrat (int a)
{
int n = a % 10; 
int b = a / 10000;
int c = a / 100 % 10;
int d = a / 1000 % 10;   
if (a > 99999)
{   
Console.WriteLine("nevernoe chislo");

}
else if (n ==b || c == d)
{
Console.WriteLine("palindrom");
}
else 
{
 Console.WriteLine("ne palindrom");
}
}
Kvadrat(33633);