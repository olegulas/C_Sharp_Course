/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/

void Print(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write($"{Math.Round(arr[i, j], 1)}\t");
        Console.WriteLine();
    }
    Console.WriteLine();

}


double[,] FillArrayNums(int row, int column, double start, double last)
{   /*
        Функция заполнения массива arr[], числами в диапазоне [start, last]
        c выходом массива в точку вызова
    */
    double[,] arr = new double[row, column];
    if (last < start)
    {   // обработка, если диапазон задали неправильно
        double buf = start;
        start = last;
        last = buf;
    }

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
        {
            Random rnd = new Random();
            arr[i, j] = (rnd.NextDouble() * (last - start) + start);
        }
    return arr;
}

Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());
Console.Write("Enter the number start Random array: ");
double startArr = double.Parse(Console.ReadLine());
Console.Write("Enter the number finish Random array: ");
double finishArr = double.Parse(Console.ReadLine());

double[,] arr_1 = FillArrayNums(row, column, startArr, finishArr);
Print(arr_1);
