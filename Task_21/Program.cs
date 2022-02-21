// Проверить пятизначное число на полиндром

System.Console.WriteLine("Ввведите пятизначное число:");
string number = Console.ReadLine();

int len = number.Length;

if (number[0] == number[len - 1] && number[1] == number[len - 2])
{
    System.Console.WriteLine("Ваше число полиндром");
}
else System.Console.WriteLine("Вы ввели обычное число.");