/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

void Print(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write($"{arr[i, j],4}\t");
        Console.WriteLine();
    }
    Console.WriteLine();
}


int[,] FillArrayNums(int row, int column, int start, int last)
{   /*
        Функция заполнения массива arr[], числами в диапазоне [start, last]
        c выходом массива в точку вызова
    */
    int[,] arr = new int[row, column];
    if (last < start)
    {   // обработка, если диапазон задали неправильно
        int buf = start;
        start = last;
        last = buf;
    }

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
        {
            arr[i, j] = new Random().Next(start, last + 1);
        }
    return arr;
}

double AverageColumnElements(int[,] arr, int j)
{
    double avrSum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        avrSum += arr[i, j];
    }
    return avrSum / arr.GetLength(0);
}

void PrintAverColumnElements(int[,] arr)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        if (j == arr.GetLength(1) - 1)
        {
            Console.WriteLine($"{Math.Round(AverageColumnElements(arr, j), 2)}.");
            return;
        }
        Console.Write($"{Math.Round(AverageColumnElements(arr, j), 2)}; ");
    }

}

Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());
Console.Write("Enter the number start Random array: ");
int startArr = int.Parse(Console.ReadLine());
Console.Write("Enter the number finish Random array: ");
int finishArr = int.Parse(Console.ReadLine());

int[,] arr_1 = FillArrayNums(row, column, startArr, finishArr);
Print(arr_1);
PrintAverColumnElements(arr_1);


