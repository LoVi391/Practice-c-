﻿// Задача 27: Напишите программу, которая принимает на
// вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.WriteLine(" Введите число -> ");

int value = int.Parse(Console.ReadLine());

{
	int result = 0;
	while (value > 0)
	{
		result+= value % 10;
		value /= 10;
	}
	Console.WriteLine(result);
}

Console.ReadKey();