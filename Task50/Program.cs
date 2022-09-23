// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("Введите индекс строки: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите индекс столбца: ");
int colums = Convert.ToInt32(Console.ReadLine());

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];

    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5}, ");
            else Console.Write($"{matrix[i, j],5} ");
        }
        Console.WriteLine("|");
    }
}

void NumberMatrix(int[,] matrix)
{
    if (rows > matrix.GetLength(0) | colums > matrix.GetLength(1))
        Console.WriteLine($"{rows}{colums} -> такого числа в массиве нет");
    else
    {
        object? number = matrix.GetValue(rows, colums);
        Console.WriteLine($"{number} -> вот число");
    }
}

int[,] array2D = CreateMatrixRndInt(3, 4, 1, 99);
PrintMatrix(array2D);
NumberMatrix(array2D);
