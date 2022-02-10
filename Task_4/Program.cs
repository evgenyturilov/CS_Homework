// Задача 4 "По заданнаму номеру дня недели вывести его название"

string[] daysOfWeek = {"понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье"};

Console.WriteLine("Введите день недели");
int numberOfDay = Convert.ToInt32(Console.ReadLine());

if (numberOfDay > 0)
{
    if (numberOfDay <=7)
    {
        string todayIs = daysOfWeek[numberOfDay - 1];
        System.Console.WriteLine($"{numberOfDay}-й день недели - {todayIs}.");
    }
    else System.Console.WriteLine("В неделе 7 дней! Попробуйте еще раз!");
} 
  