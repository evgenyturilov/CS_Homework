// Найти точку пересечения двух прямых заданных 
// уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы

int k1 = 5, k2 = 6, b1 = 3, b2 = 5;
int[] rangeOfCoordX = new int[201];

void FillArray(int[] array)
{
    for (int i = 0; i <= 200; i++)
    {
        array[i] = i - 100;
        //Console.Write($"{rangeOfCoordX[i]} ");
    }
}

FillArray(rangeOfCoordX);

int coordX = 0;
int coordY = 0;

for (int i = 0; i <= 200; i++)
    {
        if ((k1*rangeOfCoordX[i] + b1) == (k2*rangeOfCoordX[i] + b2)) 
        {
            coordX = rangeOfCoordX[i];
            coordY = k1*rangeOfCoordX[i] + b1;
        }
    }

Console.WriteLine($"Прямые пересекаются в точке с координатами: x = {coordX}, y = {coordY}");