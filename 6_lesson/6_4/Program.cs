void Massiv(int[,] arr)
	{
	    int stolb = arr.GetLength(1);
        int raw = arr.GetLength(0);
	
	    for (int i = 0; i < raw; i++)
	        {
                for (int j = 0; j < stolb; j++)
                    Console.Write($"{arr[i,j]} ");
	            Console.WriteLine();
            }    
	}
int[,] Print(int raw, int stolb)
	{
	    int[,] arr = new int[raw, stolb];
	
	    for (int i = 0; i < raw; i++)
	        for (int j = 0; j < stolb; j++)
	        arr[i,j] = new Random().Next(100,1000);
	    return arr;
	}
int[,] MasClone(int [,] arr)
{
    int stolb = arr.GetLength(1);
    int raw = arr.GetLength(0);
    int [,] new_arr = new int [raw, stolb];

    for (int i = 0; i < raw; i++)
        {
            for (int j = 0; j < stolb; j++)
                new_arr[i,j] = arr[i, j];
        }    
    return new_arr;    
}    

int[,] arr_1 = Print(int.Parse(Console.ReadLine()),
                    int.Parse(Console.ReadLine()));
Massiv(arr_1);
int[,] arr_2 = MasClone(arr_1);
Massiv(arr_2);
