// Написать программу, которая обменивает элементы первой строки и последней строки.

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

void ChangeOfElements(int[,] matr)
{
    for (int i = 0; i < numberOfColumns; i++)
    {
        int temp = matr[0, i];
        matr[0, i] = matr[numberOfStrings - 1, i];
        matr[numberOfStrings - 1, i] = temp;
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
ChangeOfElements(matrix);
PrintArray(matrix);


