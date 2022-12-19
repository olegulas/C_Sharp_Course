/* Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

void Print(int[,] arr)
{
    int size = arr.GetLength(0);

    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
            Console.Write($" {arr[i, j],4} ");
        Console.WriteLine();
    }
    Console.WriteLine();

}


int[,] MassNums(int size, int from, int to)
{
    int[,] arr = new int[size, size];

    for (int i = 0; i < size; i++)
        for (int j = 0; j < size; j++)
            arr[i, j] = new Random().Next(from, to);

    return arr;
}

int[,] MultiplyTwoMatrix(int[,] arr1, int[,] arr2, int size)
{
    int[,] multiplyArr = new int[size, size];
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            int sum = 0;
            for (int k = 0; k < size; k++)
            {
               sum  += arr1[i, k] * arr2[k, j];
            }
            multiplyArr[i, j] = sum;
        }
    }
    return multiplyArr;
}

Console.Write("Please enter size of matrix: ");
int size = int.Parse(Console.ReadLine());
Console.Write("Please enter start and last random elements for matrix: ");
int[,] arr_1 = MassNums(size,
                        int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()));
Console.Write("Please enter start and last random elements for matrix: ");
int[,] arr_2 = MassNums(size,
                        int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()));
Console.WriteLine("1 array:");
Print(arr_1);
Console.WriteLine("2 array:");
Print(arr_2);
Console.WriteLine("Multiply array:");
Print(MultiplyTwoMatrix(arr_1, arr_2, size));
