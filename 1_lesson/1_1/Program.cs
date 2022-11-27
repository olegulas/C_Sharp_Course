Console.Write("Enter integer digit a = ");
int a = int.Parse(Console.ReadLine());

Console.Write("Enter integer digit b = ");
int b = int.Parse(Console.ReadLine());

if (Math.Pow(b, 2) == a) Console.WriteLine("Yes");
else Console.WriteLine("No");