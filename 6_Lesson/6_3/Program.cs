﻿// Задача 3: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
void Fibo(int num)
{
    int a = 0;
    int b = 1;
    for (int i = 0; i < num; i++)
    {
        Console.Write($"{a} ");
        (a,b) = (b, a +b);
    }
}
Fibo(5);