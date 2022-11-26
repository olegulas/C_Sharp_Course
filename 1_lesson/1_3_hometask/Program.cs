int i_count = 1;
Console.Write("Please, enter the digit N: ");
int digN = int.Parse(Console.ReadLine());

while (i_count <= digN)
{
    if (i_count % 2 == 0) Console.Write(i_count + " ");
    i_count++;
}