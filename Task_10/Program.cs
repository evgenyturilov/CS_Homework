// Задача 10: "Показать последнюю цифру трехзначного числа"/Любого числа

/*System.Console.WriteLine("Введите трехзначное число:");
string number = Console.ReadLine();


System.Console.WriteLine($"Последняя цифра вашего числа: {number[2]}");*/

System.Console.WriteLine("Введите число:");
string number = Console.ReadLine();

int numberCipher = number.Length;

System.Console.WriteLine($"Последняя цифра в вашем числе: {number[numberCipher - 1]}");
