// Задать массив из 12 элементов, заполненных числами из [-9, 9].
// Найти сумму положительных/отрицательных элементов массива.

int[] arr = new int[12];

void FillArray(int[] arrray)
{
    for (int i = 0; i < arrray.Length; i++)
    {
        arrray[i] = new Random().Next(-9, 10);
    }
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int FindSumOfPositive(int[] array)
{
    int sumPositive = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) sumPositive = sumPositive + array[i];
    }
    return sumPositive; 
}
int FindSumOfNegative(int[] array)
{
    int sumNegative = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0) sumNegative = sumNegative + array[i];
    }
    return sumNegative; 
}

FillArray(arr);
PrintArray(arr);
Console.WriteLine();
Console.WriteLine($"Сумма положительных элементов массива равна: {FindSumOfPositive(arr)}");
Console.WriteLine($"Сумма отрицательных элементов массива равна: {FindSumOfNegative(arr)}");