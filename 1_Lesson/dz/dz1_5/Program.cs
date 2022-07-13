// Напишите программу, котрая на вход принимает на вход трехзначное число и на выходе показывает 
// последнюю цифру этого числа.
Console.WriteLine("Write a number: ");
string s_a = Console.ReadLine();

int a = int.Parse(s_a);

    Console.WriteLine(a % 10);


