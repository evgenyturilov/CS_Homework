// Фибоначчи (первые два числа либо 0 и 1, либо 1 и 1, последующие равны сумме 2-х предыдущих)

decimal fRec = 0;
decimal fIter = 0;

decimal FibonacciRecursion(int n)
{
    //if (n == 0 || n == 1) return 1;
    //else return FibonacciRecursion(n - 1) + FibonacciRecursion(n - 2);
    fRec++;
    return n == 0 || n == 1 ? 1 : FibonacciRecursion(n-1) + FibonacciRecursion(n-2);
}

decimal FibonacciIteration(int n)
{
    fIter++;
    decimal result = 1;
    decimal f0 = 1;
    decimal f1 = 1;
    for (int i = 2; i <= n; i++)
    {
        result = f0 + f1;

        f0 = f1;
        f1 = result;
        fIter++;
    }
    return result;
}

DateTime dt = DateTime.Now;

Console.ReadLine();
for (int m = 10; m < 40; m++)
{
    Console.WriteLine($"FibIter({m}) = {FibonacciIteration(m)} fIter = {fIter.ToString("### ### ###"),-15}");
    fIter = 0;
}
Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);

Console.WriteLine();
Console.ReadLine();

DateTime dt_2 = DateTime.Now;

for (int m = 10; m < 40; m++)
{
    Console.WriteLine($"FibRec({m}) = {FibonacciRecursion(m)} fRec = {fRec.ToString("### ### ###"),-15}");
    fRec = 0;
}
Console.WriteLine((DateTime.Now - dt_2).TotalMilliseconds);
Console.ReadLine();
