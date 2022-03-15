// Показать двумерный массив размером m×n заполненный вещественными числами

int[,] matrix = new int[5,4];

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++ )
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(-9,10);
        }
    }
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"  {matr[i,j]}  ");
        }
        Console.WriteLine();
    }
}

FillArray(matrix);
PrintArray(matrix);
