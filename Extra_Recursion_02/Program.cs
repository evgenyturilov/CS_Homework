// Дано натуральное число N. Выведите все его цифры по одной, в обратном порядке, разделяя их пробелами или новыми строками.
// При решении этой задачи нельзя использовать строки, списки, массивы (ну и циклы, разумеется). Разрешена только рекурсия и целочисленная арифметика.

int number = 1234;

string Recursion(int n)
{
    if (n > 0) return $"{n%10}" + Recursion(n/10);
    else return String.Empty;
}

Console.WriteLine(Recursion(number));


int numberTwo = 56789;

int RecursionTwo(int m)
{
    if (m < 10) return m;
    else
    {
        Console.Write($"{m%10}");
        return RecursionTwo(m/10);
    } 
}

Console.WriteLine(RecursionTwo(numberTwo));