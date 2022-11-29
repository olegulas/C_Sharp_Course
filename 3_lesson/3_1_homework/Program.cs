/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними 
в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
double distBetPoints3d(int[] x1, int[] x2)
{
    return Math.Sqrt(Math.Pow(x2[0]-x1[0], 2) 
         + Math.Pow(x2[1]-x1[1], 2)
         + Math.Pow(x2[2]-x1[2], 2));
}

int[] a = new int[] {7, -5, 0};
int[] b = new int[] {1, -1, 9};

Console.WriteLine(distBetPoints3d(a, b));