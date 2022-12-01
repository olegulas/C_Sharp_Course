// 2. Напишите программу, которая принимает на вход
//    число N и выдаёт произведение чисел от 1 до N.

int Proiz(int num)
{
    int summ = 1;
    for (int i = 1; i <= num; i++)
    {
        summ *= i;
    }
    return summ;
}

Console.WriteLine(Proiz(int.Parse(Console.ReadLine())));