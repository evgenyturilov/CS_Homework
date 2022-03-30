// Написать программу вычисления функции Аккермана

int AkkermanFunction(int m, int n)
{
    if (m == 0) return n + 1;
    if (n == 0 && m > 0) return AkkermanFunction(m - 1, 1);
    else return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
}

Console.WriteLine(AkkermanFunction(3,0));
