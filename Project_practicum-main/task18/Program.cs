﻿/*Задача 18: Напишите программу, которая по
заданному номеру четверти, показывает диапазон
возможных координат точек в этой четверти (x и y).*/

Console.WriteLine("введите номер четверти: ");
int n = int.Parse(Console.ReadLine());
if(n == 1 )
{
	Console.WriteLine("x > 0, y > 0");
}
else if (n == 2)
{
Console.WriteLine(" x < 0, y > 0");
}
else if (n == 3)
{
Console.WriteLine(" x < 0, y < 0");
}
else if (n == 4)
{
Console.WriteLine(" x > 0, y < 0");
}
else 
{
Console.WriteLine(" Не корректный ввод");
}