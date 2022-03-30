// Написать программу возведения числа А в целую степень B

int Rec(int a, int b)
{
    if (b == 0) return 1;
    else return a*Rec(a,b - 1);;
}

Console.WriteLine(Rec(3,6));