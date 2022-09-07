// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();
Console.WriteLine("Введите число: ");
int digit = Convert.ToInt32(Console.ReadLine());
int count = 1;

if (digit > 0)
{
    while (count <= digit)
    {
        Console.WriteLine($"{count} -> {count * count * count}");
        count++;
    }
}
else if (digit <= 0)
{
    while (count >= digit)
    {
        Console.WriteLine($"{count} -> {count * count * count}");
        count--;
    }
}

