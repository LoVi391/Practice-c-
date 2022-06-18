/*
Задача 32: Напишите программу замена элементов
массива: положительные элементы замените на
соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]
*/

int size = 4;
int[] nums = new int[size];

var newRnd = new Random();

for (int i = 0; i < size; i++)
{
	nums[i] = newRnd.Next(1, 10);
}

Console.WriteLine(string.Join(' ', nums));

for (int i = 0; i < size; i++)
{
	nums[i] *= -1;
}
Console.WriteLine(string.Join(' ', nums));

Console.ReadKey();









//Console.WriteLine("");
