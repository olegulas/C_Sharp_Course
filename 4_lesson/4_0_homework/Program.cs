/*
Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Без модуля Math, используем цикл for.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
int Exponentiation(int value, int exp)
{
    int Result = 1;
    for (int i = 1; i <= exp; i++)
    {
        Result *= value;
    }
    return Result;
}
Console.Write("Enter digit: ");
int num = int.Parse(Console.ReadLine());
Console.Write("Enter exp: ");
int expon = int.Parse(Console.ReadLine());
Console.Write($"Digit {num} in pow {expon} = {Exponentiation(num, expon)}");