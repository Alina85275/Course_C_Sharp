// Задача 1.  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
int stepen (int a, int b)
{
    int st = a;
    for (int i = 2; i <= b; i++)
    {
        st *=a;
    }
    return st;
}
Console.WriteLine("Write a number: ");
int num_1 = int.Parse(Console.ReadLine());
Console.WriteLine("Write a number: ");
int num_2 = int.Parse(Console.ReadLine());

Console.WriteLine(stepen(num_1, num_2));




