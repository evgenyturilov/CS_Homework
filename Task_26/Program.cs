// Возведите число А в натуральную степень B используя цикл

int numberA = 5;
int numberB = 3;
int result = 1;

for (int i = 0; i < numberB; i++)
{
    result = result*numberA;
}
System.Console.WriteLine(result);
