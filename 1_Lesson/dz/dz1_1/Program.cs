// Напишите программу, которая на вход принимает 2 числа и выдает, какое число большее, а какое меньшее.
Console.WriteLine("Write a number: ");
string s_a = Console.ReadLine();
Console.WriteLine("Write b number: ");
string s_b = Console.ReadLine();

int a = int.Parse(s_a);
int b = int.Parse(s_b);
if (a > b)
{
    Console.WriteLine("a>b");
}
else if (a == b)
{
    Console.WriteLine("b=a");

}
else
{
    Console.WriteLine("b>a");
}