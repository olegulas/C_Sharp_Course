/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

void Print(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write($"{arr[i, j], 4}\t");
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

void findPositionElement(int[,] arr, int pos)
{
    int maxPos = (arr.GetLength(0)) * (arr.GetLength(1));
    int i = (int)Math.Round(pos/(double)arr.GetLength(1), MidpointRounding.ToPositiveInfinity);
    int j = Math.Abs(arr.GetLength(1) - Math.Abs((maxPos - pos)%(arr.GetLength(1) )));
    if (pos < 1) 
        Console.Write("position of the element cannot be less than 1!");   
    else if (pos > maxPos)
        Console.Write($"position of the element cannot be greater than {maxPos}!");
    else
        Console.Write($"Element in position ({pos}) in array locate ({i},{j}) = {arr[i-1,j-1]}");
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
Console.Write("Enter the number finish Random array: ");
int findElem = int.Parse(Console.ReadLine());
findPositionElement(arr_1, findElem);

