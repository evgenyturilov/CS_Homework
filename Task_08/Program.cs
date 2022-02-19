// Задача 8 "Показать числа от -N до N"

System.Console.WriteLine("Введите число:");
int N = Convert.ToInt32(Console.ReadLine());

int K = -N;
int[] array = new int[2*N + 1];

for (int i = 0; i < 2*N + 1; i++)
{
    array[i] = K;
    K = K + 1;
    System.Console.Write($"{array[i]} ");
}