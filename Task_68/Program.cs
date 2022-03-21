// Показать натуральные числа от M до N, N и M заданы

Console.WriteLine("Введите первое число:");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int numberN = Convert.ToInt32(Console.ReadLine());


void Function(int n, int m)
{
    if (n < m)
    {
        if (n == m) return m;
        else return (Function((m - 1), n));
    }
}

System.Console.WriteLine(Function(numberN,numberM));