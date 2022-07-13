// See https://aka.ms/new-console-template for more information
Console.WriteLine("Write a number a: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Write a number b: ");
int b = int.Parse(Console.ReadLine());

if (b == a * a)
{
    Console.WriteLine("Yes");
}
else 
{
    Console.WriteLine("No");
}