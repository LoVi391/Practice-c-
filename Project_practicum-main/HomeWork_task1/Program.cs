// Напишите программу, которая 
// на выход принимает два числа
// и выдаёт, какое число большее,
// а какое меньшее.

Console.WriteLine("Ввидите целое число а:" + " ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("введите число b" + " ");
int num2 = int.Parse(Console.ReadLine());
int max = num1;
int min = num2;

if (num1 < num2) max = num2; min = num1;
if (num1 > num2) max = num1; min = num2;
{
	Console.WriteLine($"{max}");
	Console.WriteLine($"{min}");
	Console.WriteLine($" Это максимальное число -> {max}");
	Console.WriteLine($" Это минимальное  число -> {min}");
}


