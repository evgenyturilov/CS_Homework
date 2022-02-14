// Определить количество цифр в числе

/*Console.WriteLine("Введите число:");
string A = Console.ReadLine();

int numberOfDigits = A.Length;

System.Console.WriteLine(numberOfDigits);*/

int n = 123;
int n1;
int count = 0;
n1 = n;

while(n != 0)
{
    n = n/10;
    count++;
}
System.Console.WriteLine("{0,8} {1,8}",n1, count);
