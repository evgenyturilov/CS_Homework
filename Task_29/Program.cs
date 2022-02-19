// Написать программу вычисления произведения чисел от 1 до N

System.Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

int[] array = new int[number];
int multNumber = 1;
int arrayNumber = 1;

for (int i = 0; i < array.Length; i++)
{
    array[i] = arrayNumber;
    arrayNumber++;
    multNumber = multNumber*array[i];
}

System.Console.WriteLine($"Произведение чисел от 1 до {number} равняется {multNumber}");