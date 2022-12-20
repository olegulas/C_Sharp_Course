/* Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

int SumInterval2Digit(int value1, int value2)
{
    if (value1 == value2) return value1;
    return SumInterval2Digit(value1 + 1, value2) + value1;
}

Console.Write("Enter the start digit of interval: ");
int start = int.Parse(Console.ReadLine());
Console.Write("Enter the last digit of interval: ");
int last = int.Parse(Console.ReadLine());
Console.Write($"The amount of the interval digits ({start}..{last}) = {SumInterval2Digit(start, last)}");
