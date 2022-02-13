// Удалить вторую цифру трехзначного числа


System.Console.WriteLine("Введите трехзначное число:");
string number = Console.ReadLine();

number = number.Remove(1, 1);

System.Console.WriteLine(number);
