/*
Задача 3:
Напишите программу, которая выводит третью цифру
заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
void secondNumberInDigit(int num)
{
int buf;
Console.WriteLine($"The random number: {num}");
    while (true)
    {
        buf = num % 10;
        num = num / 10;
        if (num > 9 && num < 100)
        {
            Console.Write($"Third digit - {buf}");
            break;
        }
        else
            if (num < 10)
                {
                    Console.Write("no third digit!");
                    break;
                }
            continue;
    }
}

secondNumberInDigit(new Random().Next(1, 10000));