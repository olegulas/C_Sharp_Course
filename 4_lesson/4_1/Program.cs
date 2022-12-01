// 1. Напишите программу, которая принимает
//    на вход число и выдаёт количество цифр в числе.

int LengthDigit(int num)
{
    int n = num, count = 0;
    while (n > 0)
    {
        n = n / 10;
        count++;
    }
    return count;
}

Console.WriteLine(LengthDigit(int.Parse(Console.ReadLine())));

