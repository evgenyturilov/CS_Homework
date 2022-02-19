// Дано число. Проверить кратно ли оно 7 и 23.

System.Console.WriteLine("Введите число:");

int number = Convert.ToInt32(Console.ReadLine());

if (number % 7 == 0 && number % 23 == 0)
{
    Console.WriteLine($"Число {number} кратно 7 и 23");
}
else
{
    Console.WriteLine($"Число {number} не кратно ни 7 и ни 23");
}