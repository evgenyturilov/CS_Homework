// Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, что это невозможно (в случае, если матрица не квадратная).

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
            matrix[i, j] = new Random().Next(0, 10);
        }
    }
}

void ChangeStringsToColumns(int[,] matr)
{
    if (m != n) Console.WriteLine("Матрица не квадратная!");
    else 
        {
            for (int i = 0; i < m - 1; i++)
                {
                    for (int j = 0; j < m - 1; j++)
                    {
                        int temp = matr[i + 1, j];
                        matr[i + 1, j] = matr[i, j + 1];
                        matr[i, j + 1] = temp;
                    }
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
ChangeStringsToColumns(matrix);
PrintArray(matrix);
