// Собрать строку с числами от a до b, a <= b

string NumbersFor(int a, int b)
{
    string result = String.Empty;
    for (int i = a; i <= b; i++)
    {
        result += $"{i} ";
    }
    return result;
}
string NumbersRec(int a, int b)
{
    if (a <= b) return $"{a} " + NumbersRec(a + 1, b);
    else return String.Empty;
}
Console.WriteLine(NumbersFor(1, 10));
Console.WriteLine(NumbersRec(1, 10));

// Найти сумму чисел от 1 до n

int sumFor(int n)
{
    int result = 0;
    for (int i = 0; i <= n; i++) result += i;
    return result;
}
int sumRec(int n)
{
    if (n == 0) return 0;
    else return n + sumRec(n - 1);
}
Console.WriteLine(sumFor(10));
Console.WriteLine(sumRec(10));

// Найти факториал числа

int FactorialFor(int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++) result *= i;
    return result;
}
int FactorialRec(int n)
{
    if (n == 1) return 1;
    else return n * FactorialRec(n - 1);
}

Console.WriteLine(FactorialFor(5));
Console.WriteLine(FactorialRec(5));

// Вычислить а в степени n

int PowerFor(int a, int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++) result *= a;
    return result;
}
int PowerRec(int a, int n)
{
    // return n == 0 ? 1: PowerRec(a, n - 1) * a;
    if (n == 0) return 1;
    else return PowerRec(a, n - 1) * a;
}
int PowerRecMath(int a, int n)
{
    if (n == 0) return 1;
    else if (n % 2 == 0) return PowerRecMath(a * a, n / 2);
    else return PowerRecMath(a, n - 1) * a;
}

Console.WriteLine(PowerFor(2, 6));
Console.WriteLine(PowerRec(2, 6));
Console.WriteLine(PowerRec(2, 6));

// В некотором машинном алфавите имеются четыре буквы "а", "и", "с".
// Покажите все слова, состоящие из T букв, которые можно построить из букв этого алфавита.
// 17:00 - 18:00

int n = 1;
void FindWords(string alphabet, char[] word, int length = 0)
{
    if (length == word.Length)
    {
        Console.WriteLine($"{n++} {new String(word)}"); return;
    }
    for (int i = 0; i < alphabet.Length; i++)
    {
        word[length] = alphabet[i];
        FindWords(alphabet, word, length + 1);
    }
}
FindWords("аис", new char[5]);