Console.Write("Enter first digit: ");
int dig1 = int.Parse(Console.ReadLine());
Console.Write("Enter second digit: ");
int dig2 = int.Parse(Console.ReadLine());

if (dig1 > dig2) 
    Console.Write(dig1 + " > " + dig2);
else if (dig1 <  dig2) 
    Console.Write(dig1 + " < " + dig2);
else if (dig1 ==  dig2) 
    Console.Write(dig1 + " = " + dig2);
else
    Console.Write("Error");