// Найти сумму элементов от M до N, N и M заданы.

Console.Write("Введите первое число: ");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberTwo = Convert.ToInt32(Console.ReadLine());

int SumOfNumbers(int n, int m)
{
    if (n == m) return n;
    else return (n + (SumOfNumbers(n + 1, m)));
}

if (numberOne < numberTwo)
{
    Console.Write($"Сумма чисел от {numberOne} до {numberTwo} равна: ");
    Console.WriteLine(SumOfNumbers(numberOne,numberTwo));
}
if (numberOne > numberTwo)
{
    Console.Write($"Сумма чисел от {numberTwo} до {numberOne} равна: ");
    Console.WriteLine(SumOfNumbers(numberTwo,numberOne));
}
if (numberOne == numberTwo)
{
     Console.WriteLine("Числа равны!");
}

