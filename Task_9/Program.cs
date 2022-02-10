// Задача 9 "Показать четные числа от 1 до N"

Console.WriteLine("Введите число:");
int N = Convert.ToInt32(Console.ReadLine());

int[] numbers = new int[N];
numbers[0] = 1;

Console.Write($"В ряде чисел от 1 до {N}, ");

for(int i = 0; i < N - 1; i++)
{
    numbers[i + 1] = numbers[i] + 1;
    //Console.Write(numbers[i] + " ");
}

Console.Write("четные: ");
for(int i = 0; i < numbers.Length; i++)
{
    if (numbers[i]%2 == 0) Console.Write(numbers[i] + " ");
}
