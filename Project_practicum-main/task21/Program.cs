// Задача 21: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21


Console.Write("введите координату xa ");
var xa = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату ya ");
var ya = Convert.ToInt32(Console.ReadLine());
Console.Write("введите координату xb "); 
var xb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату yb ");
var yb =Convert.ToInt32(Console.ReadLine());
 double xy = Math.Sqrt((xa - xb) * (xa-xb) + (yb - ya) * (yb-ya));
Console.Write(xy);

//AB = √(xb - xa)2 + (yb - ya)2