// Задать номер четверти, показать диапазоны для возможных координат

Console.Write("Задайте номер четверти- ");
string n = Console.ReadLine();
if(n == "1")
{
    Console.WriteLine("x > 0, y > 0");
}
else if(n == "2")
{
    Console.WriteLine("x < 0, y > 0");
}
else if(n == "3")
{
    Console.WriteLine("x < 0, y < 0");
}
else if(n == "4")
{
    Console.WriteLine("x > 0, y < 0");
}