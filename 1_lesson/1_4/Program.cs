Console.Write("Enter digit: ");
int num = int.Parse(Console.ReadLine());

if (num < 0) Console.Write(num + " -> " + -num);
else Console.Write(num + " -> " + num);