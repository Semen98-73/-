// // Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

Console.Clear();
Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
double[] arr = new double[size];
FillArray(arr);
PrintArray(arr);

double min = Int32.MaxValue;
double max = Int32.MinValue;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > max)
    {
        max = arr[i];
    }
    if (arr[i] < min)
    {
        min = arr[i];
    }
}
Console.Write("-> ");
Console.WriteLine((Math.Round(max-min,2, MidpointRounding.AwayFromZero)));

void FillArray(double[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        array[i] = Convert.ToDouble(new Random().Next(10, 1000))/10;
    }
}

void PrintArray(double[] array)
{
    int count = array.Length;
    Console.Write("[");
    for (int i = 0; i < count; i++)
    {
        if (i == count - 1) Console.Write($"{array[i]}] ");
        else Console.Write($"{array[i]}; ");
    }
}