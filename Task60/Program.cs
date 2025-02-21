﻿// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

Console.WriteLine($"Введите размер массива X x Y x Z: ");
Console.WriteLine("Введите X ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y ");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Z ");
int z = Convert.ToInt32(Console.ReadLine());
Console.Write($"");

int[,,] array3D = new int[x, y, z];
void WriteArray(int[,,] array3D)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            Console.Write($"X({i}) Y({j}) ");
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                Console.Write($"Z({k})={array3D[i, j, k]}; ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

void CreateArray(int[,,] array3D)
{
    int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
    int number;
    Random rnd = new Random();
    for (int i = 0; i < temp.GetLength(0); i++)
    {
        temp[i] = rnd.Next(10, 100);
        number = temp[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                                while (temp[i] == temp[j])
                {
                    temp[i] = rnd.Next(10, 100);
                    j = 0;
                    number = temp[i];
                }
                number = temp[i];
            }
        }
    }
    int count = 0;
    for (int x = 0; x < array3D.GetLength(0); x++)
    {
        for (int y = 0; y < array3D.GetLength(1); y++)
        {
            for (int z = 0; z < array3D.GetLength(2); z++)
            {
                array3D[x, y, z] = temp[count];
                count++;
            }
        }
    }
}

CreateArray(array3D);
WriteArray(array3D);
