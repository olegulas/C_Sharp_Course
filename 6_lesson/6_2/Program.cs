// 2. Напишите программу, которая будет
//    преобразовывать десятичное число в двоичное.

string ConvertDecBin(int num)
{
    string res = string.Empty;
    while (num > 0)
    {
        res = num % 2 + res;
        num /= 2;
    }
    return res;
}

Console.WriteLine(ConvertDecBin(int.Parse(Console.ReadLine())));