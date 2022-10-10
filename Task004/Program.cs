// Найти расстояние между точками в пространстве 2D/3D
Console.Write("Введите значение х1 - ");
int x1 = Convert.ToInt32(Console.ReadLine() ?? "0");
Console.Write("Введите значение y1 - ");
int y1 = Convert.ToInt32(Console.ReadLine() ?? "0");
Console.Write("Введите значение z1 - ");
int z1 = Convert.ToInt32(Console.ReadLine() ?? "0");
Console.Write("Введите значение х2 - ");
int x2 = Convert.ToInt32(Console.ReadLine() ?? "0");
Console.Write("Введите значение y2 - ");
int y2 = Convert.ToInt32(Console.ReadLine() ?? "0");
Console.Write("Введите значение z2 - ");
int z2 = Convert.ToInt32(Console.ReadLine() ?? "0");
var result1 = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
Console.WriteLine("Расстояние межде точками на плоскости - " +result1);
var result2 = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
Console.WriteLine("Расстояние межде точками в пространтсве - " +result2);