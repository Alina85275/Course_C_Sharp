﻿// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний
//и т.д. Результат запишите в новом массиве.

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
        arr[i] = new Random().Next(1,10);
    }
    return arr;
}

int[] PairsNum(int[] arr)
{
    int size = arr.Length;
    int Flex_size = size / 2 + size % 2;
    int[] new_arr = new int[Flex_size];
for (int i = 0; i < size / 2; i++)

    new_arr[i] = arr[i] * arr[size -i -1];

    if (new_arr[Flex_size - 1] == 0);
    new_arr[Flex_size - 1] = arr[Flex_size - 1];
    return new_arr;
}
int[] arr_1 = MassNums(5);
print(arr_1);
int[] new_arr_1 = PairsNum(arr_1);
print(new_arr_1);