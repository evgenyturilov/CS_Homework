// Задать двумерный массив следующим правилом: Aₘₙ = m+n

Console.WriteLine("Введите параметр m:");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите параметр n:");
int n = int.Parse(Console.ReadLine());

int[,] matrix = new int[m, n];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for ( int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = i + j;
        Console.Write($"[{i}, {j}] = {matrix[i, j]} |");
    }
    Console.WriteLine();
}