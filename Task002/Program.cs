// По двум заданным числам проверять является ли одно квадратом другого

Console.WriteLine("Введите первое число");
double f = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите второе число");
double s = Convert.ToDouble(Console.ReadLine());
if(f == s * s)
{
    Console.WriteLine("Первое число является квадратом второго");
}
else if(s == f * f)
{
    Console.WriteLine("Второе число является квадратом первого");
}
else
{
    Console.WriteLine("не является");
}
