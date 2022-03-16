// Написать программу масштабирования фигуры

struct Point  
{
    // ООП - инкапсуляция
    public int x, y; // поля структуры
    // public string name = "No name";

    public void Print()
    {
        System.Console.WriteLine($"x = {x} y = {y}");
    }
}

class Programm
{
    static void Scale( int k,ref Point a, ref Point b, ref Point c) // передача по ссылке
    {
        a.x = a.x * k;
        a.y = a.y * k;
        b.x *= k;
        b.y *= k;
        c.x *= k;
        c.y *= k;
    }
   
    static voit Calc( int a, int b, out int multi, out int sum) // если есть out, то значения переменным можно не присваивать, если они будут расчитаны в методе.
    {
        multi = a * b;
        sum = a + b;
    }

    static void Main()
    {
        int x = 1, b = 2, s, m;
        Calc(x, y,out m, out s);
        
        Point a;
        Point b;
        Point c;
        a.x = 0; a.y = 2; //a.name = "a";
        b.x = 1; b.y = 3; //b.name = "b";
        c.x = 2; c.y = 4; //c.name = "c";
        a.Print();
        b.Print();
        c.Print();
        Scale(2, ref a, ref b, ref c);
        a.Print();
        b.Print();
        c.Print();
    }
}

