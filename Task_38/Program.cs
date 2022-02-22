// Найти сумму чисел одномерного массива стоящих на нечетной позиции

void FillArray(int[] arrray)
{
    for (int i = 0; i < arrray.Length; i++)
    {
        arrray[i] = new Random().Next(1, 100);
    }
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
int SumOfOddPos(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0) sum = sum + array[i];
    }
    return sum;
}

int[] arr = new int[10];
FillArray(arr);
PrintArray(arr);
System.Console.WriteLine($"Сумма элементов массива, стоящих на нечетной позиции равна {SumOfOddPos(arr)}");