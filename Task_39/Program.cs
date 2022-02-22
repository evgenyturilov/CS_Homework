// Найти произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д

void FillArray(int[] arrray)
{
    for (int i = 0; i < arrray.Length; i++)
    {
        arrray[i] = new Random().Next(1, 10);
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

int[] arr = new int[10];
FillArray(arr);
PrintArray(arr);

int len = arr.Length;
for (int i = 0; i < len/2; i++)
{
    int mult = arr[i] * arr[(len-1) - i];
    System.Console.Write($"{mult} ");
}
