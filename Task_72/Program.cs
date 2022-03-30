// Написать программу возведения числа А в целую степень B

int Rec(int a, int b)
{
    if (b == 1) return a;
    else return a*Rec(a,b - 1);;
}

Console.WriteLine(Rec(3,6));