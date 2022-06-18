/*
Задача 21: Напишите программу, которая принимает на
вход координаты двух точек и находит расстояние между
ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/


Console.Write("введите координату xa ");
var xa = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату ya ");
var ya = Convert.ToInt32(Console.ReadLine());
Console.Write("введите координату xb ");
var xb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату yb ");
var yb = Convert.ToInt32(Console.ReadLine());
Console.Write("введите координату xc ");
var xc = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату yc ");
var yc = Convert.ToInt32(Console.ReadLine());
double xyc = Math.Sqrt((xa - xb - xc) * (xa - xb - xc) + (yb - ya - yc) * (yb - ya - yc));
Console.Write(xyc);