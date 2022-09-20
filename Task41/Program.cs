// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[size];
Console.WriteLine("Введите числа");
FillArray(arr);
PrintArray(arr);
NumbersArray(arr);

void NumbersArray(int[] array)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (array[i] > 0)
            count++;
    }
    Console.Write($"-> {count}");
}

void FillArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
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


