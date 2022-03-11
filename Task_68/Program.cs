// Показать натуральные числа от M до N, N и M заданы

string Numbers(int m, int n)
{
    if (m <= n) return $"{m} " + Numbers(m + 1, n);
    else return String.Empty;
}
Console.WriteLine(Numbers(10, 20));
