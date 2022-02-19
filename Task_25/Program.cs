// Найти сумму чисел от 1 до N

System.Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = new int[number];
int arrayNumber = 1;
int sum = 0;

for(int i = 0; i < array.Length; i++)
{
    array[i] = arrayNumber;
    arrayNumber++;
    sum = sum + array[i];
}
System.Console.WriteLine($"Сумма чисел от 1 до {number} равняется {sum}");