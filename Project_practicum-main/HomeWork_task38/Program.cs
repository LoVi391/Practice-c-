// Задача 38: Задайте массив вещественных чисел. Найдите
// разницу между максимальным и минимальным
// элементов массива.

Console.Clear();

void FillArray(double[] collection)
{
	int length = collection.Length;
	int index = 0;
	while (index < length)
	{
		index++;
	}
}

void PrintArray(double[] colArray)
{
	int count = colArray.Length;
	int position = 0;
	while (position < count)
	{
		Console.Write(colArray[position] + " ");
		position++;
	}
}

double[] array = { -12, 16, 13, 15, 14 }; ;
FillArray(array);
PrintArray(array);

Array.Sort(array);

var min = array[0];
var max = array[0];

for (int i = 0; i < array.Length; i++)
{
	if (array[i] < min)
	{
		min = array[i];
	}
	else if (array[i] > max)

		max = array[i];
}
// Console.WriteLine($"Минимальное: {min}");
// Console.WriteLine($"Максимальное: {max}");
Console.WriteLine($"Разница: {max - min}");
Console.ReadKey();
