void Chisla(int a)
{
    if(a == 0) return;
    Chisla(a-1);
    Console.Write($" {a} ");
}
Chisla(5);
