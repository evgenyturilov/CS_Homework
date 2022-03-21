// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

int numberOfStrings, numberOfColumns;
int[,] matrix;

void Input(out int numberOfStrings, out int numberOfColumns)
{
    Console.WriteLine("Введите количество строк в матрице:");
    numberOfStrings = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов в матрице:");
    numberOfColumns = int.Parse(Console.ReadLine());
}

void FillArray(int numberOfStrings, int numberOfColumns)
{
    matrix = new int[numberOfStrings, numberOfColumns];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
        }
    }
}

void FindAverageOfColumns(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        int sum = 0;
        double average = 0;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sum = sum + matr[j, i];
        }
        average = (double) sum / numberOfStrings;
        Console.WriteLine($"Среднеарифметическое элементов столбца {i + 1}: {average,6:F2}");    
    }
    Console.WriteLine();
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

Input(out numberOfStrings, out numberOfColumns);
FillArray(numberOfStrings, numberOfColumns);
PrintArray(matrix);
Console.WriteLine();
FindAverageOfColumns(matrix);

