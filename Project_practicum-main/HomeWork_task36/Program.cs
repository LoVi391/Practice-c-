// Задача 36: Задайте одномерный массив, заполненный
// случайными числами. Найдите сумму элементов, стоящих
// на нечётных позициях.
Console.Clear();
void FillArray(int[] collection)
{
	int length = collection.Length;
	int index = 0;
	while (index < length)
	{
		collection[index] = new Random().Next(1, 10);

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

int sum = 0;

Array.Sort(array);

for (int i = 0; i < array.Length; i++)
{
	if (array[i] % 2 != 0) sum += array[i];
	else array[i] = 0;
}
Console.WriteLine();
Console.WriteLine("сумма нечетных элементов {0}, ", sum);
Console.ReadKey();