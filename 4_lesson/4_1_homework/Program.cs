/*
Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
int GetSumFromDigit(int num)
{
    int Result = 0;
    for (; num > 0;)
    {
        Result += num % 10;
        num = num / 10;
    }
    return Result;
}

Console.Write("Enter digit: ");
int num = int.Parse(Console.ReadLine());
Console.Write($"{num} -> {GetSumFromDigit(num)}");