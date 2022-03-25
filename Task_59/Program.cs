// В прямоугольной матрице найти строку с наименьшей суммой элементов.

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

void MaxSumOfStrElements(int[,] matr)
{ 
    int[] sumMatr = new int[numberOfStrings];
    for (int str = 0; str < matr.GetLength(0); str++)
    {
        int sum = 0;
        for (int i = 0; i < matr.GetLength(1); i++)
        {
            sum = sum + matr[str,i];
        }
      
        sumMatr[str] = sum;
        Console.WriteLine($"Cумма элементов {str + 1} строки равна: {sum, 7}");
    }
    Console.WriteLine();

    int max = sumMatr[0];
    int strNumber = 0;

    for (int j = 1; j < sumMatr.GetLength(0); j++)
        {
            if (sumMatr[j] > max) 
            {
                max = sumMatr[j];
                strNumber = j;
            }
        }
        Console.WriteLine($"Максимальная сумма элементов в {strNumber + 1} строке и равна {max}");
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
MaxSumOfStrElements(matrix);






