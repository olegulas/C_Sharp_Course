int Degree(int a, int b)
{
    if (b == 0) return 1;
    return Degree(a, b - 1) * a;
}

Console.WriteLine(Degree(5, 3));