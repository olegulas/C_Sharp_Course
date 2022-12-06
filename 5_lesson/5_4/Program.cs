/* Задача 4: Найдите произведение пар чисел в одномерном массиве.
Парой считаем первый и последний элемент, второй и предпоследний
и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21 */

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

int[] NewArr(int[] arr)
{
    int to = arr.Length / 2;         // переменная середины массива
    int[] NewArr;                    // новый массив

    bool chet = arr.Length % 2 == 0; // переменная четности количества чисел в массиве(да/нет)

    if (chet)
        NewArr = new int[to];
    else
        NewArr = new int[to + 1];

    // заполнение нового массива произведением зеркальных элементов
    for (int i = 0; i < to; i++)
    {
        NewArr[i] = arr[i] * arr[arr.Length - 1 - i];
    }

    // если массив с нечетным числом, выдираем серединку в новый
    if (!chet)
        NewArr[NewArr.Length - 1] = arr[to];

    return NewArr;
}
Console.Clear();
Console.WriteLine("Введите через Enter: Размер массива, " +
                 "Начало, Конец диапазона случайных чисел");
                 
int[] arr_1 = ArrayNums(Convert.ToInt32(Console.ReadLine()),
                        Convert.ToInt32(Console.ReadLine()),
                        Convert.ToInt32(Console.ReadLine()));

Print(arr_1, "Исходный массив:");
Print(NewArr(arr_1), "Новый массив: ");