// Задача 2: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
int Summa ( int  proizv)
{
    int allSum = 1;
for(int i = 1; i <= proizv; i++)
 allSum = allSum * i;
 return allSum;
}
Console.WriteLine(Summa(4));
