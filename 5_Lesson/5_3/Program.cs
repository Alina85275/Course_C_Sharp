// Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в
//отрезке [10,99]. 
void print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int[] MassNums(int size, int from, int to)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(from, to);
    }
    return arr;
}

int Nums(int[] arr)
{
int count = 0;
for(int i = 0; i < arr.Length; i++)
{
    if (arr[i]>= 10 && arr[i]<=99)
    count++;
}
return count;
}
int[] arr_1 = MassNums(123, -9,10);
print(arr_1);
Console.WriteLine(Nums(arr_1));
