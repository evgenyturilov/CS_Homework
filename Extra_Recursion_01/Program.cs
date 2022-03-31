
// Является ли число результатом возведения 2 в натуральную степень


Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

string IsExponentResult(int n)
{
    if (n == 1) return "Да";
    else if (n%2 == 0) return IsExponentResult(n/2);
    else return "Нет";
}

Console.WriteLine("Является ли число результатом возведения 2 в натуральную степень?");
Console.WriteLine((IsExponentResult(number)));