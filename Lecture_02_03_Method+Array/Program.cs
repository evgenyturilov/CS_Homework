// Начало работы с массивами в C#, имеется одномерный массив array из N элементов, требуется найти элемент массива равный find

int[] array = { 14, 24, 63, 24, 85, 46, 67, 98, 39 };

int n = array.Length;
int find = 85;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        System.Console.WriteLine(index);
        break;
    }
    index++;
}
