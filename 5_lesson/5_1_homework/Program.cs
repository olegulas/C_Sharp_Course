/*Задача 2: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 26
[-4, -6, 4, 6] -> 0*/
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
    {   // обработка, если диапазон задали неправильно
        int buf = start;
        start = last;
        last = buf;
    }
    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(start, last + 1);
    return arr;
}

int SumNotEvenElem(int[] arr)
{
    int sumElem = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 == 0)
            sumElem += arr[i];
    }
    return sumElem;
}

Console.Clear();
Console.WriteLine("Введите через Enter: Размер массива, " +
                 "Начало, Конец диапазона случайных чисел");
                 
int[] arr_1 = ArrayNums(Convert.ToInt32(Console.ReadLine()),
                        Convert.ToInt32(Console.ReadLine()),
                        Convert.ToInt32(Console.ReadLine()));

Print(arr_1, "Исходный массив:");
Console.WriteLine($"Сумма элементов нечетных позиций {SumNotEvenElem(arr_1)}");