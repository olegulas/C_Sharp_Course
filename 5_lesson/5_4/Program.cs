/* Задача 4: Найдите произведение пар чисел в одномерном массиве.
Парой считаем первый и последний элемент, второй и предпоследний
и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21 */

void Print(int[] arr)
{   /*
        Функция печати массива arr[]
    */
    int size = arr.Length;

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

int[] arr_1 = ArrayNums(int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()));
Print(arr_1);