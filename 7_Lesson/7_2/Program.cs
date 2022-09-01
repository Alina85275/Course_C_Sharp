// Задача 2: Задайте двумерный массив. Найдите элементы, у которых 
//обе позиции чётные, и замените эти элементы на их квадраты.
void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for(int i = 0; i < row_size; i++)
    {
        for(int j = 0; j < column_size; j++)
        {
            Console.Write($" {arr[i,j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


int[,] MassNums(int row, int column, int from, int to)
{
   int[,] arr = new int[row, column];

    for(int i = 0; i < row; i++)
    {
        for(int j = 0; j < column; j++)
        {
           arr[i,j] = new Random().Next(from, to);
        }
    }
    return arr;
}


int[,] XZ(int [,] arr)
{
   
    for(int i = 0; i < arr.GetLength(0); i+=2)
    {
        for(int j = 0; j < arr.GetLength(1); j+=2)
        {
           arr[i,j] *=arr[i,j];
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    return arr;
}

int[,] arr_1 = MassNums(3,4,-9,10);
Print(arr_1);
XZ(arr_1);
Print(arr_1);