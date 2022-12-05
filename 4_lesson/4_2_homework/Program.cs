/*
Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

void PrintArrayInt(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == arr.Length - 1)
        {
            Console.Write($"{arr[i]}");
            Console.Write("]");
            return;
        }
        Console.Write($"{arr[i]}, ");
    }
    Console.Write("]");
}

void InitRandArr(int[] arr, int startRand, int lastRand)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(startRand, lastRand + 1);
    }
    PrintArrayInt(arr);
}

Console.Write("Enter size array: ");
int size = int.Parse(Console.ReadLine());
Console.Write("Enter start digit for Rand init array: ");
int start = int.Parse(Console.ReadLine());
Console.Write("Enter last digit for Rand init array: ");
int last = int.Parse(Console.ReadLine());
int[] array = new int [size];
InitRandArr(array, start, last);
