/*
Напишите программу, которая на вход принимает 
число и выдаёт, является ли число чётным 
(делится ли оно на два без остатка).
*/

Console.WriteLine("введите целое число :");
int numbersA = int.Parse(Console.ReadLine());

if (numbersA % 2 == 1)

{
	Console.WriteLine($"Нет");
}
else
{
	Console.WriteLine($"Да");
}
Console.ReadKey();


