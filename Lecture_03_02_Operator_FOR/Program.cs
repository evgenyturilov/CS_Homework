// Применение цикла for, цикл в цикле

string Method4(int count, string text)
{
    string result = String.Empty;

    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

string res = Method4(10, "q");
System.Console.WriteLine(res);

// Задача о выведении таблицы умножения на экран

for (int i = 2; i < 10; i++)
{
    for (int j = 2; j < 10; j++)
    {
        System.Console.WriteLine($"{i}*{j}={i * j}");
    }
    System.Console.WriteLine();
}

// Задача: Дан текст. В таксте нужно все пробелы заменить черточками, маленькте буквы "к"
// заменить большими "К", а большие "С" заменить маленькими "с".


string text = "Дан текст. В таксте нужно все пробелы заменить черточками, маленькте буквы 'к' заменить большими 'К', а большие 'С' заменить маленькими 'с'.";

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int lenght = text.Length;
    for (int i = 0; i < lenght; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}

string newText = Replace(text,' ','|');
System.Console.WriteLine(newText);
newText = Replace(text,'к','К');
System.Console.WriteLine(newText);
newText = Replace(text,'С','с');
System.Console.WriteLine(newText);