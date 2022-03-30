// Найти сумму цифр числа

int number = 717;

int SumOfDigits(int n)
{
    if (n < 10) return n;
    else return n%10 + SumOfDigits(n/10);
}

Console.WriteLine(SumOfDigits(number));
