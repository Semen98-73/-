// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
Console.Write("Введите любое число: ");
int number = Convert.ToInt32(Console.ReadLine()); ;
int num = number;
if (number <= 99)
{
    Console.WriteLine("Третьей цифры нет");
}
else if (number >= 100 && number < 1000)
{
    num = number % 10;
    Console.WriteLine($"{num}");
}
else
{
    while (num >= 1000)
    {
        num = num / 10;
    }
    num = num % 10;
    Console.WriteLine($"{num}");
}
