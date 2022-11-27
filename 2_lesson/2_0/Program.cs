int maxDigit(int arg)
{
    Console.WriteLine($"Random digit is {arg}");
    if (arg / 10 >= arg % 10)
        return arg / 10;
    else
        return arg % 10; 
}

Console.Write($"Max number - {maxDigit(new Random().Next(10,100))}");