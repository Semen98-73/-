// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
Console.WriteLine("введите число");
int i = Convert.ToInt32(Console.ReadLine());
int sum = 0;
for (int num = 0; i > 0;)
{
    num = i % 10;
    i = i / 10;
    sum = sum + num;
}
Console.WriteLine($"Cумма цифр в числе равна: {sum}");