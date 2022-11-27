/*
Задача 4:
Напишите программу, которая принимает на вход цифру,
обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

bool isHoliday(int day)
{
    Console.WriteLine($"It's day - {day}");
    if (day == 6 || day == 7) return true;
    else return false;
}

Console.WriteLine(isHoliday(new Random().Next(1,8)));