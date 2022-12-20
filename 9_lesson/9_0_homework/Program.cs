/* Задача 1: Задайте значение N. Напишите программу, которая выведет все четные натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "4, 2"
N = 8 -> "4, 6, 8" */

string SeriesEvenNumbers(int value)
{
    if (value < 2)
        return "Error, BAN";
    else if (value % 2 != 0)
        return SeriesEvenNumbers(value - 1);
    else if (value == 2)
        return "2";
    return $"{value}, {SeriesEvenNumbers(value - 1)}";
}

Console.Write("Enter the digit: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine(SeriesEvenNumbers(n));