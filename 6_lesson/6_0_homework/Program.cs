//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3


void CountingPosNumbers()
{
    int countPosNum = 0;
    string digitalSeries = string.Empty;
    while (true)
    {
        string bufNum = Console.ReadLine();
        if (bufNum == "")
            break;

        digitalSeries += bufNum + " ";

        if (int.Parse(bufNum) > 0)
            countPosNum++;
    }
    Console.WriteLine($"positive numbers in entered array: {digitalSeries}=> {countPosNum}");
}

CountingPosNumbers();