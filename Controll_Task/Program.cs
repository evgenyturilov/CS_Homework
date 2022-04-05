// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.

string[] originArray = {"Все", "мы", "гении", ".", "Но", "если", "вы", "будете", "судить", "рыбу", "по", "её", "способности", "взбираться", "на", "дерево", ",", "она", "проживёт", "всю", "жизнь", ",", "считая", "себя", "дурой", "."};


void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

string[] SortArray(string[] array)
{
    string[] sortedArray = new string[array.Length];
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            sortedArray[count] = array[i];
            count++;
        }
    }
    return sortedArray;
    
}


PrintArray(originArray);
PrintArray(SortArray(originArray));

