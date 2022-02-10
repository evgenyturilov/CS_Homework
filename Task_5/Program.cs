// Задача 5 "Найти максимальное из трех чисел"

int a = new Random().Next(1,11);
int b = new Random().Next(1,11);
int c = new Random().Next(1,11);

Console.WriteLine($"a = {a}");
Console.WriteLine($"b = {b}");
Console.WriteLine($"c = {c}");
Console.WriteLine();

int max = a;

if (b > a) max = b;
if (c > a) max = c;
Console.WriteLine($"Максимальное число {max}");