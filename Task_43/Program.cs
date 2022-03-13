﻿// Написать программу преобразования десятичного числа в двоичное

System.Console.WriteLine("Введите число:");
int decimalNumber = int.Parse(Console.ReadLine());

int a = decimalNumber;
int len = 0;
while (a != 0)
{
    a = a/2;
    len++;
}

int[] binaryNumber = new int[len];

int b = decimalNumber;
for (int i = 0; i < len; i++)
{
    binaryNumber[i] = b%2;
    b = b/2;
}
System.Console.WriteLine();
System.Console.Write($"Десятичное число {decimalNumber} в двоичном виде: ");
for (int i = len-1; i >= 0; i --)
{
    Console.Write(binaryNumber[i]);
}
