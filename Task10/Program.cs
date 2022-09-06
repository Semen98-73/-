// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
Console.Write("Введите трёхзначное целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100)
{
    Console.WriteLine("Число не трёхзначное");
}
else if (number > 999)
{
    Console.WriteLine("Число не трёхзначное");
}
else if (number >= 100 && number <= 999)
{
    int MaxDigit(int num)
    {
        int firstandthirdDigit = num % 100;
        int secondDigit = num % 10;
        return (firstandthirdDigit - secondDigit) / 10;
    }
    int result = MaxDigit(number);
    System.Console.WriteLine(result);
}



