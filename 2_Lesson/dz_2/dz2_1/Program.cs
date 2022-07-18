// Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую
// цифру этого числа.

Console.WriteLine("Write a number: ");
string s_a = Console.ReadLine();

int a = int.Parse(s_a);

    Console.WriteLine(a / 10  % 10);
