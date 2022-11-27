int maxDigit(int arg)
{
    Console.WriteLine($"Random digit is {arg}");     
    return arg % 100 % 10;  
}

Console.Write($"Max number - {maxDigit(new Random().Next(100,1000))}");