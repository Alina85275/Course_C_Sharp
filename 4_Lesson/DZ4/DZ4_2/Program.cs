// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
int summa (int a)
{
   int summ = 0;
    while (a>0)
{
    
    summ = summ + a % 10;
    a = a/10;
}
return summ;
}
Console.WriteLine(summa(452));
