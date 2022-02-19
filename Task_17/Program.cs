// По двум заданным числам проверить является ли одно квадратом другого

Console.WriteLine("Введите первое число:");
int numberOne = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int numberTwo = Convert.ToInt32(Console.ReadLine());

bool SquareOrNot(int arg1, int arg2)
{
    if (arg2*arg2 == arg1) return true;
    else return false;
}

if (SquareOrNot(numberOne, numberTwo) == true) 
{
    Console.WriteLine("Первое число является квадратом второго.");
}
else Console.WriteLine("Первое число не является квадратом второго.");

if (SquareOrNot(numberTwo, numberOne) == true)
{
    Console.WriteLine("Второе число является квадратом первого");
}
else Console.WriteLine("Второе число не является квадратом первого");