/*Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/
void Print(int[] arr, string msg)
{   /*
        Функция печати массива arr[]
    */
    int size = arr.Length;
    Console.WriteLine(msg);
    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

int[] ArrayNums(int size, int start, int last)
{   /*
        Функция заполнения массива arr[], числами в диапазоне [start, last]
        c выходом массива в точку вызова
    */

    int[] arr = new int[size];
    if (last < start)
    {
        int buf = start;
        start = last;
        last = buf;
    }
    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(start, last + 1);
    return arr;
}

int DigitEvenMas(int[] arr)
{
    int countEven = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
            countEven++;
    }
    return countEven;
}

Console.Clear();
Console.WriteLine("Введите через Enter: Размер массива, " +
                 "Начало, Конец диапазона случайных чисел");
                 
int[] arr_1 = ArrayNums(Convert.ToInt32(Console.ReadLine()),
                        Convert.ToInt32(Console.ReadLine()),
                        Convert.ToInt32(Console.ReadLine()));

Print(arr_1, "Исходный массив:");
Console.WriteLine($"Количество четных элементов {DigitEvenMas(arr_1)}");