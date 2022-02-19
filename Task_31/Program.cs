// Задать массив из 8-ми элементов и вывести их на экран

int[] array = {31, 53,25 ,76 ,28 ,29 ,36, 79};

for(int i = 0; i < array.Length; i++)
{
    System.Console.WriteLine("{0, 8}", array[i]);
}
