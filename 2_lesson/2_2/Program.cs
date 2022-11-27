 void maxDigit(int arg1, int arg2)
{
    Console.WriteLine($"In digits {arg1} and {arg2}:");
    if (arg1 % arg2 == 0) 
        Console.WriteLine("multiple");
    else 
        Console.WriteLine(arg1 % arg2);
}

maxDigit(new Random().Next(1, 101), new Random().Next(1, 10));