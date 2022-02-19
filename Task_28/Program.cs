// Подсчитать сумму цифр в числе

/*
//Решение №1

System.Console.WriteLine("Введите число");
string yourNumber = Console.ReadLine();

System.Console.WriteLine($"В вашем числе {yourNumber.Length} цифр.");
*/

// Решение №2

double number = new Random().Next(1,100000000);
Console.WriteLine(number);

string a = Convert.ToString(number);

Console.WriteLine($"В числе {number} {a.Length} цифр.");
