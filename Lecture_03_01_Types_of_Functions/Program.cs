// Типы методов в C#

// Тип 1 ничего не принимают и ничего не возвращают

void Method1()
{
    Console.WriteLine("Автор ...");
}
Method1();

//Тип 2 ничего не возвращают, но могут принимать аргументы

/*
void Method2(string msg);
{
    Console.WriteLine(msg);
}
*/

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        System.Console.WriteLine();
        i++;
    }
}

Method21(msg: "Text", count: 4);

// Тип 3 ничего не принимает, но возвращает

int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
System.Console.WriteLine(year);

// Тип 4 и принимают аргументы и возвращают

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(10, "q");
System.Console.WriteLine(res);