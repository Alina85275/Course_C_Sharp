//Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

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

void chislo(int[] arr)
{
    
int ch = int.Parse(Console.ReadLine());
for(int i = 0; i < arr.Length; i++)
{
    if (arr[i] == ch)
    Console.WriteLine("yes");
    else 
    Console.WriteLine("no");  
}
}
int[] arr_1 = MassNums(12, -9,10);
print(arr_1);
chislo(arr_1);

