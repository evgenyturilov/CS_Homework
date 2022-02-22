// В Указанном массиве вещественных чисел найдите разницу 
// между максимальным и минимальным элементом.

void FillArray(int[] arrray)
{
    for (int i = 0; i < arrray.Length; i++)
    {
        arrray[i] = new Random().Next(1, 1000);
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
int FindMax(int[] array)
{
    int maxNum = array[0];
    for (int j = 1; j < array.Length; j++)
    {
        if (array[j] > maxNum) maxNum = array[j];
    }
    return maxNum;
}
int FindMin(int[] array)
{
    int minNum = array[0];
    for (int j = 1; j < array.Length; j++)
    {
        if (array[j] < minNum) minNum = array[j];
    }
    return minNum;
}

int[] arr = new int[10];
FillArray(arr);
PrintArray(arr);
Console.WriteLine($"Разница между максимальным и минимальным элементом массива равна: {FindMax(arr) - FindMin(arr)}");
