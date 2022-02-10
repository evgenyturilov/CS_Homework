// Задача 3 "Даны два числа, показать большее и меньшее число"

/*int a = new Random().Next(1,11);
int b = new Random().Next(1,11);

Console.WriteLine($"a = {a}");
Console.WriteLine($"b = {b}");
Console.WriteLine();*/

System.Console.WriteLine("Введите первое число:");
int numberOne = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число:");
int numberTwo = Convert.ToInt32(Console.ReadLine());

if (numberOne > numberTwo) Console.WriteLine($"Число {numberOne} больше, чем {numberTwo}");
if (numberOne < numberTwo) Console.WriteLine($"Число {numberTwo} больше, чем {numberOne}");

if (numberOne == numberTwo) Console.WriteLine($"Числа {numberOne} и {numberTwo} равны");
