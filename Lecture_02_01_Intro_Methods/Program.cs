// Начало работы с методами в C#, задача на нахождение максимального числа.
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int a1 = 56;
int a2 = 43;
int a3 = 78;
int b1 = 35;
int b2 = 49;
int b3 = 82;
int c1 = 43;
int c2 = 136;
int c3 = 58;

// int max1 = Max(a1, a2, a3);
// int max2 = Max(b1, b2, b3);
// int max3 = Max(c1, c2, c3);
// int max = Max(max1, max2, max3);

int max = Max(Max(a1,a2,a3), Max(b1,b2,b3), Max(c1,c2,c3));
System.Console.WriteLine($"Максимальное число из заданных - {max}");