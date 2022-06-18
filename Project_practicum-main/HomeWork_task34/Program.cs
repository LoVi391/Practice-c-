// Задача 34: Задайте массив заполненный случайными
// положительными трёхзначными числами. Напишите
// программу, которая покажет количество чётных чисел в
// массиве.

void FillArray(int[] collection)
{
	int length = collection.Length;
	int index = 0;
	while (index < length)
	{
		collection[index] = new Random().Next(100, 1000);

		index++;
	}
}

void PrintArray(int[] colArray)
{
	int count = colArray.Length;
	int position = 0;
	while (position < count)
	{
		Console.Write(colArray[position] + " ");
		position++;
	}
}

int[] array = new int[10];
FillArray(array);
PrintArray(array);

int j = 0;
Array.Sort(array);

foreach (int element in array)
{
	Console.Write("{0} ", element);
	if (element % 2 == 0)
	{
		j++;
	}
}
Console.WriteLine();
Console.WriteLine("Количество четных элементов {0}, ", j);
Console.ReadKey();




