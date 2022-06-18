/*
Напишите программу, которая принимает 
 на вход три числа и выдаёт максимальное из этих чисел.
 */


Console.WriteLine(" введите целое число a:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" введите целое число b:");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число c");
int num3 = Convert.ToInt32(Console.ReadLine());
int max = num1;
int min = num2;


if (num1 < num2 && num2 < num3 && num1 < num3 ) max = num3;
if (num1 > num2 && num2 > num3 && num1 > num3 ) max = num1;
if (num1 < num2 && num2 > num3 && num1 > num3 ) max = num2;
{
	Console.WriteLine($"Максимальное число {max}");
}

Console.ReadKey();