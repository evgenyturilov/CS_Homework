// Показать натуральные числа от 1 до N, N задано.

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

int Series(int n)
{
    if ( n == 1) return 1;
    else return Series(n-1) + 1;
}


Console.WriteLine($"Натуральные числа от 1 до {number}:");
for (int i = 1; i <= number; i++)
{
    Console.Write($"{Series(i)} ");
}