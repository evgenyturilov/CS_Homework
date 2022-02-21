// Написать программу замены элементов массива на противоположные.

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
void ChangeElements(int[] array)
{
    for(int i = 0; i<array.Length; i++)
    {
        array[i] = array[i]*(-1);
    }
}

int[] arr = new int[10];
FillArray(arr);
PrintArray(arr);
Console.WriteLine();
ChangeElements(arr);
PrintArray(arr);