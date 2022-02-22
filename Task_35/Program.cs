// Определить, присутствует ли в заданном массиве, некоторое число.

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
bool FindNumber(int[] array, int number)
{
    bool isHere = false;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number) isHere = true;
    }
    return isHere;
}

int[] arr = new int[10];
FillArray(arr);
PrintArray(arr);

System.Console.WriteLine("Введите число:");
int yourNum = Convert.ToInt32(Console.ReadLine());

if (FindNumber(arr, yourNum) == true) Console.WriteLine("Данное число есть в массиве");
else Console.WriteLine("Данного числа нет в массиве");