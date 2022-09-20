// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();
Console.WriteLine("Введите число точки b1");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число точки k1");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число точки b2");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число точки k2");
double k2 = Convert.ToDouble(Console.ReadLine());

double FindX(double b10, double k10, double b20, double k20)
{
    double x1 = Math.Round((-b20 + b10) / (-k10 + k20), 1);
    return x1;
}
double FindY(double b20, double k20, double x1)
{
    double y1 = Math.Round((k20*x1+b20),1);
    return y1;
}
double result1 = FindX(b1, k1, b2, k2);
double result2 = FindY(b2, k2, result1);
Console.WriteLine($"{result1}, {result2}");
