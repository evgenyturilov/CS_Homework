// Дано число из отрезка [10, 99]. Требуется показать наибольшую цифру данного числа.

int number = new Random().Next(10, 100);

string strNumber = Convert.ToString(number);

if (strNumber[0] > strNumber[1]) System.Console.WriteLine($"Наибольшая цифра в числе {number} - {strNumber[0]}");
else System.Console.WriteLine($"Наибольшая цифра в числе {number} - {strNumber[1]}");
