﻿// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
try
{
    Console.WriteLine("Введите поочередно каждую координату двух точек по осям х, y, z");
    int x1 = Convert.ToInt32(Console.ReadLine());
    int y1 = Convert.ToInt32(Console.ReadLine());
    int z1 = Convert.ToInt32(Console.ReadLine());
    int x2 = Convert.ToInt32(Console.ReadLine());
    int y2 = Convert.ToInt32(Console.ReadLine());
    int z2 = Convert.ToInt32(Console.ReadLine());
    double Dist = distance(x1, y1, z1, x2, y2, z2);
    Console.WriteLine($"Расстояние между двумя точками равно {Dist}");
}
catch
{
    Console.WriteLine("Нужно вводить цифрами поочередно координаты каждой точки");
}

double distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double res = Math.Pow((Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)), 0.5); //расстояние 3D=корень из ((x2 - x1)2 + (y2 - y1)2 + (z2 - z1)2) . Math Pow(a,b) требует в b степень, поэтому вводим 0,5 чтоюы избавиться от корня
    return res;
}


