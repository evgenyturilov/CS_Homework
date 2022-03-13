﻿// Выяснить являются ли три числа сторонами треугольника

double a = 10, b = 4, c = 7;

bool IsTriangle(double x, double y, double z)
{
    bool flag;
    flag = (x + y > z && x + z > y && y + z > x);
    return flag;
}
// if -оператор
// (условие) ? вернуть, если истино : вернуть, если ложно

System.Console.WriteLine($"{a} {b} {c} - " + (IsTriangle(a, b, c) ? "Это стороны треугольника" : "Этот не стороны треугольника"));
