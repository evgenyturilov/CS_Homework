# CS_Homework
  Task_1 "Вывести квадрат числа"
  Task_2 "По двум заданным числам проверить является ли первое квадратом второго"
  Task_3 "Даны два числа, показать большее и меньшее число"
  
    int a = new Random().Next(1,11);
    int b = new Random().Next(1,11);

    Console.WriteLine($"a = {a}");
    Console.WriteLine($"b = {b}");
    Console.WriteLine();

    if (a > b) Console.WriteLine($"{a} больше, чем {b}");
    if (a < b) Console.WriteLine($"{a} больше, чем {b}");
    
    if (a == b) Console.WriteLine($"{a} и {b} равны");
   
 Task_4 "По заданному номеру дня недели вывести его название" 
 Task_5 "Найти максимальное из трех чисел"
 
    int a = new Random().Next(1,11);
    int b = new Random().Next(1,11);
    int c = new Random().Next(1,11);

    Console.WriteLine($"a = {a}");
    Console.WriteLine($"b = {b}");
    Console.WriteLine($"c = {c}");
    Console.WriteLine();

    int max = a;

    if (b > a) max = b;
    if (c > a) max = c;
    Console.WriteLine($"Максимальное число {max}");
 Task_6 "Написать программу вычисления функции y = f(a)   
 Task_7 "Выяснить является ли число четным"
 
    int a = new Random().Next(1,100);
    Console.WriteLine(a);
    Console.WriteLine();
    
    bool oddOrEven(int arg)
    {
        if (arg%2 == 0) return true;
        else return false;
    }

    if (oddOrEven(a) == true) Console.WriteLine($"Число {a} четное");
    else Console.WriteLine($"Число {a} нечетное");
 
 Tasl_8 "Показать числа от -N до N"
 Task_9 "Показать четные числа от 1 до N"
   

    int N = Convert.ToInt32(Console.ReadLine());

    int[] numbers = new int[N];
    numbers[0] = 1;

    for(int i = 0; i < N-1; i++)
    {
        numbers[i+1] = numbers[i] + 1;
        Console.Write(numbers[i] + " ");
    }

    Console.WriteLine();

    for(int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i]%2 == 0) Console.Write(numbers[i] + " ");
    }
    
 Task_10 "Показать последнюю цифру трехзначного числа"
