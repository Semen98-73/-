// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();
Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[size];
FillArray(arr);
PrintArray(arr);

int sum = 0;
for (int i = 1; i < arr.Length; i += 2)
    sum = sum + arr[i];
Console.Write($"-> {sum}");

void FillArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        array[i] = new Random().Next(-100, 100);
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