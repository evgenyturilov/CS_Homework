// Подсчитать сумму цифр в числе

int randomNumber = new Random().Next(1,10000000);// Если вводить в Next больше 9-ти зназного числа, птшет ошибку "не удается преобразовать из "long" в "int"", каким способом можно это исправить?
int sum = 0;
int number = randomNumber;

while (number!= 0)
{
    sum = sum + number%10;
    number = number/10;
}

System.Console.WriteLine($"Сумма цифр в числе {randomNumber} равна {sum}");