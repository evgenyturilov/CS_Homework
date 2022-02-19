// Дано число, обозначающее день недели. Выяснить является ли номер дня недели выходным.

Console.WriteLine("Введите номер дня недели:");
int dayNumberInput = Convert.ToInt32(Console.ReadLine());

string[] daysOfWeek = {"понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье"};

if (daysOfWeek[dayNumberInput - 1] == "воскресенье" && daysOfWeek[dayNumberInput - 1] == daysOfWeek[6])
{
    System.Console.WriteLine($"Выбранный день недели - {daysOfWeek[dayNumberInput - 1]}, {daysOfWeek[dayNumberInput - 1]} - выходной!");
}
else
{
    System.Console.WriteLine($"Выбранный день недели - {daysOfWeek[dayNumberInput - 1]}, {daysOfWeek[dayNumberInput - 1]} - рабочий день.");
}
