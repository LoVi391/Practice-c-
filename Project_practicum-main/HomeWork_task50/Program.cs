// Задача 50: Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Clear();
Console.WriteLine(" Введите номер строки элемента -> ");
int positionRow = int.Parse(Console.ReadLine());
Console.WriteLine(" Введите номер столбца элемента -> ");
int positionCol = int.Parse(Console.ReadLine());

void FillArray(int[,] matr)
{
	for (int i = 0; i < matr.GetLength(0); i++)
	{
		for (int j = 0; j < matr.GetLength(1); j++)
		{
			matr[i, j] = new Random().Next(1, 10);
		}
	}
}
void PrintArray(int[,] array)
{
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			Console.Write($"{array[i, j]}   ");
		}
		Console.WriteLine();
	}
}

void FindPosition(int[,] arr)
{
	for (int i = 0; i < arr.GetLength(0); i++)
	{
		for (int j = 0; j < arr.GetLength(1); j++)

			if ((i == 0) && (j == 0)) arr[i, j] = arr[positionRow, positionCol];
		if (i == positionRow) Console.Write(i + " ");

		else
		{
			Console.Write($" Такого элемента нет! ");
		}
		Console.WriteLine();
	}
}
int[,] matrix = new int[20, 30];
FindPosition(matrix);
FillArray(matrix);
PrintArray(matrix);



