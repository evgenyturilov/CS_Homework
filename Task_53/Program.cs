// В матрице чисел найти сумму элементов главной диагонали

int m;
int[,] matrix;

void Input(out int m)
{
    Console.WriteLine("Введите размер матрицы:");
    m = int.Parse(Console.ReadLine());
}

void FillArray(int m)
{
    matrix = new int[m, m];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-9, 10);
        }
    }
}

void FindSumOfMainDiag(int[,] matr)
{
    int sumOfMainDiag = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (i == j) sumOfMainDiag = sumOfMainDiag + matr[i, j]; 
        }
    }
    Console.WriteLine($"Сумма элементов главной диагонали данной матрицы равняется: {sumOfMainDiag}");
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

Input(out m);
FillArray(m);
PrintArray(matrix);
Console.WriteLine();
FindSumOfMainDiag(matrix);
