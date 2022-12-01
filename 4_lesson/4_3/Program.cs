// 3. Напишите программу, которая выводит массив из 8 элементов,
//    заполненный нулями и единицами в случайном порядке.

void RandBinArray(int n)
{
    int[] arr = new int[n];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(2);
        Console.Write($"{arr[i]}");
    }
}

Console.WriteLine("Введите размер массива: ");
RandBinArray(int.Parse(Console.ReadLine()));
