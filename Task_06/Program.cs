// Задача 6 "Написать программу вычисления функции y = f(a)

Console.WriteLine("Введите число:");
double a = Convert.ToDouble(Console.ReadLine());

double Function(double argument)
{
    return argument*argument;
}

Console.WriteLine($"{a} в квадрате равно {Function(a)}");