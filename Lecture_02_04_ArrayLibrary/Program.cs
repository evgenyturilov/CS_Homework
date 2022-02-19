// Начало работы с массивами в C#, заполнение и печать массивов при помощи методов,
// нахождение требуемого числа в массиве.

void FillArray(int[] collectionOne)
{
    int lenght = collectionOne.Length;
    int index = 0;
    while (index<lenght)
    {
        collectionOne[index] = new Random().Next(1,10);
        index++;
    }
}
void PrintArray(int[] collectionTwo)
{
    int count = collectionTwo.Length;
    int position = 0;
    while(position < count)
    {
        System.Console.WriteLine(collectionTwo[position]);
        position++;
    }
    
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;

    while(index<count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);
System.Console.WriteLine();

int pos = IndexOf(array, 4);
System.Console.WriteLine(pos);