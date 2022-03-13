// Задать номер четверти, показать диапазоны для возможных координат

Console.WriteLine("Введите номер четверти (от 1 до 4):");
int numberOfQuarter = int.Parse(Console.ReadLine());

if (numberOfQuarter == 1) Console.WriteLine($"Максимальное значение координаты X = {Int32.MaxValue} , Y = {Int32.MaxValue}");
if (numberOfQuarter == 2) Console.WriteLine($"Максимальное значение координаты X = {Int32.MinValue} , Y = {Int32.MaxValue}");
if (numberOfQuarter == 3) Console.WriteLine($"Максимальное значение координаты X = {Int32.MinValue} , Y = {Int32.MinValue}");
if (numberOfQuarter == 4) Console.WriteLine($"Максимальное значение координаты X = {Int32.MaxValue} , Y = {Int32.MinValue}");