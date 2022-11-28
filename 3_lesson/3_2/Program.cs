int ReadNumber(string message)
{
    Console.Write(message);
    var s = Console.ReadLine();
    int a = s == null ? 0 : int.Parse(s);
    return a;
}
double Distance(int ax, int ay, int bx, int by)
{
    double result;
    result = Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2));
    return result;
}

int ax = ReadNumber("Введите aX:");
int ay = ReadNumber("Введите aY:");
int bx = ReadNumber("Введите bX:");
int by = ReadNumber("Введите bY:");

Console.WriteLine(Math.Round(Distance(ax, ay, bx, by), 2));
