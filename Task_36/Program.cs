// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

int[] array = new int[10];
int countEven = 0;
int countOdd = 0;
System.Console.Write("В массиве из чисел: ");
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100,1000);
    System.Console.Write($"{array[i]} ");

    if (array[i]%2 == 0)
    {
        countEven++;
    }
    else countOdd++;
}
System.Console.WriteLine();
System.Console.WriteLine($"Количество четных чисел: {countEven}");
System.Console.WriteLine($"Количество нечетных чисел: {countOdd}");

