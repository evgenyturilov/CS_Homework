// Написать программу копирования массива
int[] originArray = {12,34,56,7,43,87};
int[] array = new int[10];

void FillArray(int[] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++ )
    {
        matr[i] = new Random().Next(0, 101);
    }
    Console.WriteLine();
}

void PrintArray(int[] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        Console.Write($"{matr[i]} ");
    }
    Console.WriteLine();
    Console.WriteLine();
}

void CopyArray(int[] matr)

{
    Console.WriteLine("Массив копия:");
    Console.WriteLine();
    int[] copy = new int[matr.GetLength(0)];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        copy[i] = matr[i];
        Console.Write($"{copy[i]} ");
    }
    Console.WriteLine();
}

//FillArray(array);
//PrintArray(array);
//CopyArray(array);

CopyArray(originArray);