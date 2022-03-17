// Показать двумерный массив размером m×n заполненный вещественными числами

double[,] matrix = new double[5,4];

void FillArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++ )
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().NextDouble()*100; // NextDouble генерирует вещественные числа
            // matr[i,j] = Convert.ToDouble(new Random().Next(-99,100)) / 10;
            // matr[i,j] = new Random().Next(-99,100) / 10D;
            // matr[i,j] = new Random().Next(-99,100) / 10.1;
            // matr[i,j] = double.Parse(new Random().Next(-99,100)) / 10;
            // Console.Write("a[{0},{1}]={2,6:F2} ", i, j, a[i, j]); - F2 означает фиксированный вывод знаков после запятой (2 знака), можно использовать E2 - запись будет в экспоненциальном виде

        }
    }
}

void PrintArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"| {matr[i,j],6:F2} |");
        }
        Console.WriteLine();
    }
}

FillArray(matrix);
PrintArray(matrix);
