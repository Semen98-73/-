// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,  
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();
Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[size];
FillArray(arr);
PrintArray(arr);

int count = 0;
for (int i = 0; i < arr.Length; i++)
    if (arr[i] % 2 == 0)
        count++;
Console.Write($"-> {count}");

void FillArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
}

void PrintArray(int[] array)
{
    int count = array.Length;
    Console.Write("[");
    for (int i = 0; i < count; i++)
    {
        if (i == count - 1) Console.Write($"{array[i]}] ");
        else Console.Write($"{array[i]}, ");
    }
}