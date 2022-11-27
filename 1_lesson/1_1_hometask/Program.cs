int max;
Console.Write("Enter the first digit: ");
int dig1 = int.Parse(Console.ReadLine());
Console.Write("Enter the second digit: ");
int dig2 = int.Parse(Console.ReadLine());
Console.Write("Enter the third digit: ");
int dig3 = int.Parse(Console.ReadLine());

max = dig1;
if (max < dig2) max = dig2;
if (max < dig3) max = dig3;

Console.Write("In array digits: " + dig1 + ", " + dig2 +  ", " + dig3);
Console.Write(", max digit is = " + max);