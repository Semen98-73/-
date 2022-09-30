// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
NaturalNumbers(numberM, numberN, 0);

void NaturalNumbers(int numM, int numN, int sum)
{
    if (numM > numN)
    {
        Console.WriteLine($"M = {numberM}; N = {numberN} -> {sum}");
        return;
    }
    sum = sum + (numM++);
    NaturalNumbers(numM, numN, sum);
}