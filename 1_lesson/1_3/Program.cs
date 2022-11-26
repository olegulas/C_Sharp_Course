Console.Write("Enter digit N: ");
int n = int.Parse(Console.ReadLine());
int i_count = -n;

while (i_count <= n)
{
    if (i_count == n) 
    {
        Console.Write(i_count); 
        break;
    }
    Console.Write(i_count + ", ");
    i_count ++;
}