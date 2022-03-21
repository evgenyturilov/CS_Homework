// Написать программу, упорядочивания по убыванию элементы каждой строки двумерного массива.

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

void ArrangeOfStringElements(int[,] matr)
{
    for (int str = 0; str < matr.GetLength(0); str++)
    {
        for (int i = 0; i < matr.GetLength(1) - 1; i++)
        {
            int minPosition = i;
            for (int j = i + 1; j < matr.GetLength(1); j++)
            {
                if (matr[str, j] < matr[str, minPosition])
                {
                    minPosition = j;
                }
            }
            int temporary = matr[str, i];
            matr[str, i] = matr[str, minPosition];
            matr[str, minPosition] = temporary;
            
        }
        Console.WriteLine();
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

Input(out numberOfStrings, out numberOfColumns);
FillArray(numberOfStrings, numberOfColumns);
PrintArray(matrix);
Console.WriteLine();
ArrangeOfStringElements(matrix);
PrintArray(matrix);



