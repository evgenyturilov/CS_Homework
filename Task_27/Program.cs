// Определить количество цифр в числе


int n = 123;
int n1;
int count = 0;
n1 = n;

while(n != 0)
{
    n = n/10;
    count++;
}
System.Console.WriteLine("{0,8} {1,8}",n1, count);

/*
//Решение №1

System.Console.WriteLine("Введите число");
string yourNumber = Console.ReadLine();

System.Console.WriteLine($"В вашем числе {yourNumber.Length} цифр.");
*/

// Решение №2

/*
double number = new Random().Next(1,1000000000);// Если вводить в Next больше 9-ти зназного числа, птшет ошибку "не удается преобразовать из "long" в "int"", каким способом можно это исправить?
Console.WriteLine(number);

string a = Convert.ToString(number);

Console.WriteLine($"В числе {number} {a.Length} цифр.");
*/