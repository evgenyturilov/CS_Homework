// Задать массив из 8-ми элементов, заполненный нулями и единицами и вывести их на экран

int[] array = new int[8];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0,2);
    System.Console.WriteLine("{0,8}", array[i]);
}


