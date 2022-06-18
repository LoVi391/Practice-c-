// Задача 63 Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от 1 до N.


Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine());

NaturalNumber(n);
Console.ReadKey();

void NaturalNumber(int num)
{
	if (num == 0) return;
	NaturalNumber(num - 1);
	Console.Write(num + " ");
}