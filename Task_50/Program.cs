//  В двумерном массиве n×k заменить четные элементы на противоположные

int[,] matrix = new int[10,10];

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(10, 100);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"  {array[i, j]}  ");
        }
        Console.WriteLine();
    }
}

void ChangeEven(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j]%2 == 0) array[i,j] = -array[i,j];
        }
    }
}

FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
ChangeEven(matrix);
PrintArray(matrix);