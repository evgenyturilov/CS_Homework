// Найти сумму элементов от M до N, N и M заданы.

Console.WriteLine("Введите первое число:");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int numberN = Convert.ToInt32(Console.ReadLine());

int Series(int m, int n)
{
    if (n == m) return m;
    else return (Series(n - 1) + (Series(n - 1) + 1));
}

int n = numberN;
for (int i = numberM; i < n; i++)
{
    
    Console.WriteLine(Series(i, n));   
}

