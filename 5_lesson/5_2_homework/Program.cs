/*Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/
void Print(double[] arr, string msg)
{   /*
        Функция печати массива arr[]
    */
    int size = arr.Length;
    Console.WriteLine(msg);
    for (int i = 0; i < size; i++)
        Console.Write("{0:F2} ", arr[i]);
    Console.WriteLine();
}

double[] ArrayNums(int size, double start, double last)
{   /*
        Функция заполнения массива arr[], числами в диапазоне [start, last]
        c выходом массива в точку вызова
    */
    double[] arr = new double[size];
    if (last < start)
    {   // обработка, если диапазон задали неправильно
        double buf = start;
        start = last;
        last = buf;
    }

    for (int i = 0; i < size; i++)
    {
        Random rnd = new Random();
        arr[i] = (rnd.NextDouble() * (last - start) + start);
    }
    return arr;
}

double DiffMaxMin(double[] arr)
{
    int min, max;
    min = max = 0;
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > arr[max]) max = i;
        if (arr[i] < arr[min]) min = i;
    }
    return arr[max] - arr[min];
}

Console.Clear();
Console.WriteLine("Введите через Enter: Размер массива, " +
                 "Начало, Конец диапазона случайных чисел");

double[] arr_1 = ArrayNums(Convert.ToInt32(Console.ReadLine()),
                        Convert.ToDouble(Console.ReadLine()),
                        Convert.ToDouble(Console.ReadLine()));

Print(arr_1, "Исходный массив:");
Console.WriteLine($"Разница между максимальным и минимальным элементом массива = {DiffMaxMin(arr_1):F2}");