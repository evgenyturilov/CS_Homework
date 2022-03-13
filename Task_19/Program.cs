// Определить номер четверти плоскости,
// в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

System.Console.WriteLine("Введите координату X отличную от нуля:");
int coordX = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите координату Y отличную от нуля:");
int coordY = int.Parse(Console.ReadLine());

if (coordX > 0 && coordY > 0) System.Console.WriteLine("Заданная точка находится в I четверти");
if (coordX < 0 && coordY > 0) System.Console.WriteLine("Заданная точка находится во II четверти");
if (coordX < 0 && coordY < 0) System.Console.WriteLine("Заданная точка находится в III четверти");
if (coordX > 0 && coordY < 0) System.Console.WriteLine("Заданная точка находится в IV четверти");
else System.Console.WriteLine("Одна из координат равна нулю");
