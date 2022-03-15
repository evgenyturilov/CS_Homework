// Определить сколько чисел больше 0 введено с клавиатуры

System.Console.WriteLine("Введите число:");

int Number = Convert.ToInt32(Console.ReadLine());

int positiveNumbers = 0;
int a = Number;

while (a != 0)
{
    if (a%10 != 0) positiveNumbers++;
    a = a/10;
}

Console.WriteLine($"В числе {Number} {positiveNumbers} положительных знаков");





