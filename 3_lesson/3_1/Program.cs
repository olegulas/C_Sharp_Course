// 1. Напишите программу, которая по заданному номеру четверти,
//    показывает диапазон возможных координат точек в этой четверти (x и y).
void Quarters(string a)
{
    if (a == "I")
        Console.WriteLine("x > 0 and y > 0");
    else if (a == "II")
        Console.WriteLine("x < 0 and y > 0");
    else if (a == "III")
        Console.WriteLine("x < 0 and y < 0");   
    else if (a == "IV")
        Console.WriteLine("x > 0 and y <  0");
    else 
        Console.WriteLine("error");       

}
Quarters(Console.ReadLine());
