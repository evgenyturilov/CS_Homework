// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

int m, n;
int[,] matrix;

void Input(out int m, out int n)
{
    Console.WriteLine("Введите количество строк в матрице:");
    m = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов в матрице:");
    n = int.Parse(Console.ReadLine());
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

void Solve(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0) matr[i, j] = (int) Math.Pow(matr[i, j], 2); 
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

Input(out m, out n);
FillArray(m, n);
PrintArray(matrix);
Console.WriteLine();
Solve(matrix);
PrintArray(matrix);