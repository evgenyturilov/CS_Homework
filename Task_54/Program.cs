// В матрице чисел найти сумму элементов главной диагонали

int m, n;
int[,] matrix;

void Input(out int m, out int n)
{
    Console.WriteLine("Введите размер матрицы:");
    m = int.Parse(Console.ReadLine());
    n = m;
}

void FillArray(int m, int n)
{
    matrix = new int[m, n];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-9, 10);
        }
    }
}

void SumOfMainDiag(int[,] matr)
{
    int sum = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (i == j) sum = sum + matr[i,j]; 
        }
    }
    Console.WriteLine($"Сумма элементов главной диагонали равна {sum}");
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

Input(out m, out n);
FillArray(m, n);
PrintArray(matrix);
Console.WriteLine();
SumOfMainDiag(matrix);
Console.WriteLine();
