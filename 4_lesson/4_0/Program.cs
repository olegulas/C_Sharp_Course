// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

int sumNums(int num)
{
    int result = 0;
    for (int i = 1; i <= num; i++)
    {
        result += i;
    }
    return result;
}

Console.WriteLine(sumNums(int.Parse(Console.ReadLine())));

