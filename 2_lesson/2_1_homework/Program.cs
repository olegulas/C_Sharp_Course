/*
Задача 2:
Напишите программу, которая выводит случайное
трёхзначное число и удаляет вторую цифру этого числа.
645 -> 65
782 -> 72
918 -> 98
*/

int printEditDigits()
{
    int dig = new Random().Next(100, 1000), newDig;
    Console.WriteLine($"Source Random digit - {dig}");
    return dig / 100 * 10 + dig % 10;
}

Console.WriteLine($"Digit after cut {printEditDigits()}");