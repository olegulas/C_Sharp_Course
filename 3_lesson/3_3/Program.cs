// 3. Напишите программу, которая принимает на вход число (N) 
//    и выдаёт таблицу квадратов чисел от 1 до N.

void printArrayN(int n)
{
    int count = 1;
    while(count < n)
    {
        Console.Write(count*count + " ");
        count++;
    } 
}

printArrayN(5);