// Составить частотный словарь элементов двумерного массива состоящих из чисел от 0 до 99.

int[,] matrix  = new int[5, 5];
int[] freqArr = new int[100];
freqArr[0]++;

void FillArray(int[,] matr, int min = 0, int max = 10)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(min, max);
        }
    }
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++ )
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j], 6} |");
        }
        Console.WriteLine();
    }
}

FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
Console.WriteLine();

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        freqArr[matrix[i, j]]++;
    }
}

for (int i = 0; i < freqArr.GetLength(0); i++)
{
    if (freqArr[i] != 0)
    Console.WriteLine($"Число {i} встречается {freqArr[i]} раз.");
}


