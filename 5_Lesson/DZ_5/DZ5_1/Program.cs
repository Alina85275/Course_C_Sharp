// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите
//программу, которая покажет количество чётных чисел в массиве.
void print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int[] MassNums(int size)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(0, 1000);
    }
    return arr;
}

int chetnie(int[] arr)
{
int chet = 0;
for(int i = 0; i < arr.Length; i++)
{
    if (arr[i] % 2 == 0)
    chet++;
}
return chet;
}
int[] arr_1 = MassNums(6);
print(arr_1);
Console.WriteLine(chetnie(arr_1));
