 bool isMulpiply(int arg)
{
    Console.WriteLine($"Digit is {arg}:");
    if ( (arg % 7 ==0) && (arg % 23 == 0) ) 
        return true;
    else 
        return false;
}

Console.Write(isMulpiply(new Random().Next(1, 1001)));