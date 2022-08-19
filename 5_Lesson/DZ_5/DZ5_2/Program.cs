//Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих
//на нечётных позициях.

void print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int []  MassNums(int size)
{
    int[] arr = new int[size];
  for (int i = 0; i < size; i++)
    {
       arr[i] = new Random().Next(10);
    }
    return arr;
}

int Positciya(int[] arr)
{
    int count = 0;

    for (int i = 0; i < arr.Length; i += 2)
    {
        count += arr[i];
    }
    return count;
}

int[] arr_1 = MassNums(10);
print(arr_1);
Console.WriteLine(Positciya(arr_1));


