// Показать натуральные числа от M до N, N и M заданы

Console.Write("Введите первое число: ");
int NumberOne = int.Parse(Console.ReadLine());
Console.Write("введите второе число: ");
int NumberTwo = int.Parse(Console.ReadLine());
Console.WriteLine();

string NaturalNumbers(int a, int b) // a > b = n > m
{
    if (a <= b) return $"{a} " + NaturalNumbers(a + 1, b);
    else return String.Empty;   
}

if (NumberOne < NumberTwo) 
{
    Console.WriteLine($"Натуральные числа от {NumberOne} до {NumberTwo}:");
    Console.WriteLine(NaturalNumbers(NumberOne,NumberTwo));
}
if (NumberTwo < NumberOne) 
{
    Console.WriteLine($"Натуральные числа от {NumberTwo} до {NumberOne}:");
    Console.WriteLine(NaturalNumbers(NumberTwo, NumberOne));
}
if (NumberOne == NumberTwo)
{
    Console.WriteLine("Числа равны!");
}



