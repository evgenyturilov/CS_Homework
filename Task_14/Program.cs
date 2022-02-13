// Выяснить кратно ли число заданному, если нет вывести остаток

System.Console.WriteLine("Введите число:");
double numberOne = Convert.ToDouble(Console.ReadLine());

double numberTwo = new Random().Next(1,10);
System.Console.WriteLine($"Заданное число: {numberTwo}");

//int numberOne = 45;
//int numberTwo = 5;

double restOfDivision = numberOne%numberTwo;

if (restOfDivision == 0) System.Console.WriteLine("Ваше число кратно заданному!");
else System.Console.WriteLine($"Остаток от деления вашего числа на заданное {restOfDivision}");

