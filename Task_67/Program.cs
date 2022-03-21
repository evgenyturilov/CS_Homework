// Показать натуральные числа от N до 1, N задано.

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

int Series(int n)
{
    if (n == 1) return n;
    else return Series(n - 1) + 1;
}


Console.WriteLine($"Натуральные числа от {number} до 1:");
for (int i = number; i > 0; i--)
{
    Console.Write($"{Series(i)} ");
}
Console.WriteLine();
