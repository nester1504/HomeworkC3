﻿Console.Write("Введите координату точки A по оси Х: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату точки  A по оси Y: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату точки  A по оси Z: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату точки B по оси Х: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату точки B по оси Y: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату точки B по оси Z: ");
int z2 = Convert.ToInt32(Console.ReadLine());

var result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));

Console.WriteLine(Math.Round(result, 2));