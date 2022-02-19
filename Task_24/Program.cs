// Найти кубы чисел от 1 до N

System.Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = new int[number];
int arrayNumber = 1;
double squareNumber = 1;

for (int i = 0; i < array.Length; i++)
{
    array[i] = arrayNumber;
    arrayNumber++;
    squareNumber = Math.Pow(array[i], 3);
    System.Console.WriteLine("{0,8} {1,8}", array[i], squareNumber );
}
