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

int[] NewArr(int[] arr)
{
    int to = arr.Length / 2;       // переменная середины массива
    int[] NewArr;                   // новый массив

    bool chet = arr.Length % 2 == 0;// переменная четности количества чисел в массиве(да/нет)

    if (chet)
        NewArr = new int[to];
    else
        NewArr = new int[to + 1];

    for (int i = 0; i < to; i++)
    {
        NewArr[i] = arr[i] * arr[arr.Length - 1 - i];   //заполнение нового массива произведением зеркальных элементов
    }

    if (!chet)                      // если массив с нечетным числом, выдираем серединку в новый
        NewArr[NewArr.Length - 1] = arr[to];

    return NewArr;
}

int[] arr_1 = ArrayNums(int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()));
Console.Write("Исходный массив: ");
Print(arr_1);
Console.Write("Новый массив: ");
Print(NewArr(arr_1));