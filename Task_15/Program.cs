// Найти третью цифру числа, или сообщить, что ее нет

Console.WriteLine("Введите число:");
string number =  Console.ReadLine();
int lenght = number.Length;


if (lenght >= 3) 
{
    var thirdNumber = number[2];
    Console.WriteLine($"Третья цифра в числе {number} - {thirdNumber}");
}
else Console.WriteLine("В числе меньше трех знаков");


/*
int n = Convert.ToInt32(number);
int n1 = Convert.ToInt32(number);
int count = 0;

while (n != 0)
{
    n = n/10;
    count++;
    if (count == (lenght - temp))
    {
        n1 = n%10;
    }
}
System.Console.WriteLine(count);
if (count >= 3)
{
    System.Console.WriteLine($"Третья цифра в числе {number} - {n1}");
}
else System.Console.WriteLine("В числе меньше трех знаков");
*/



