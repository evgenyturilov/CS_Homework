// Показать числа Фибоначчи.

int Fibonacci(int n)
{
    if (n == 0 || n == 1) return 1;
    else return (Fibonacci(n - 1) + Fibonacci(n - 2));
}

System.Console.WriteLine("Введите число:");
int yourNum = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Числа Фибоначчи от 1 до {yourNum}:");

for (int i = 0; i <= yourNum; i++)
{
    Console.WriteLine($"{i} {Fibonacci(i)}");
}
