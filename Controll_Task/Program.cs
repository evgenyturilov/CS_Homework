// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых
// меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.

string[] words = {"qwerty","qwer","qwe","qw","q","2","23"};


void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++) Console.Write($"{array[i]} ");
}
Console.WriteLine();

string[] SortArray(string[] array)
{

    string[] sortedArray = new string[array.Length];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            sortedArray[i] = array[i];
        }
    }
    return sortedArray;
    
}


PrintArray(words);
Console.WriteLine();
PrintArray(SortArray(words));
Console.WriteLine();


