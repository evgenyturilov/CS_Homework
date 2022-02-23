// Показать натуральные числа от M до N, N и M заданы

Console.WriteLine("Введите первое число:");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int numberN = Convert.ToInt32(Console.ReadLine());

int Series(int n)
{
    if ( n == 1) return 1;
    else return Series(n - 1) + 1;
}

Console.WriteLine($"Натуральные числа от {numberM} до {numberN}:");
for (int i = numberM; i <= numberN; i++)
{
    Console.Write($"{Series(i)} ");
}