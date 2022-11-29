/*
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
void rowCubes(int n)
{
    int count = 1;
    while(count <= n)
    {   
        if (count == n)
        {
            Console.Write($"{Math.Pow(count, 3)} ");
            return;
        }
        Console.Write($"{Math.Pow(count, 3)}, ");
        count++;
    }
}

rowCubes(3);