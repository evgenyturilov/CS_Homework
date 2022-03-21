// Найти произведение двух матриц

int[,] matrixOne = new int [5, 5];
int[,] matrixTwo = new int [5, 5];
int[,] resultMatrx = new int [5, 5];

void FillMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(-10, 11);
        }
    }
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j], 7}  |");
        }
        Console.WriteLine();
    }
}

void MultiplyMatrixElements(int[,] matr1, int[,] matr2, int[,] matr3)
{
    for (int i = 0; i < matr1.GetLength(0); i++)
    {
        for (int j = 0; j < matr2.GetLength(1); j++)
        {
            matr3[i,j] = matr1[i, j] * matr2[i, j];
        }
    }
}

FillMatrix(matrixOne);
FillMatrix(matrixTwo);
PrintMatrix(matrixOne);
Console.WriteLine();
PrintMatrix(matrixTwo);
Console.WriteLine();
MultiplyMatrixElements(matrixOne, matrixTwo, resultMatrx);
PrintMatrix(resultMatrx);
