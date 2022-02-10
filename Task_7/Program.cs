// Задача 7 "Выяснить является ли число четным"

int a = new Random().Next(1,100);

bool oddOrEven(int arg)
{
    if (arg%2 == 0) return true;
    else return false;
}

if (oddOrEven(a) == true) Console.WriteLine($"Число {a} четное");
else Console.WriteLine($"Число {a} нечетное");
