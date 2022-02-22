// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99].

int[] arr = new int[123];

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

int NumOfElements(int[] array, int n1, int n2)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= n1 && array[i] <= n2) count = count + 1;
    }
    return count;
}

FillArray(arr);
PrintArray(arr);
Console.WriteLine($"В данном массиве {NumOfElements(arr, 10, 99)} элементов, удовлетворяющих условиям.");