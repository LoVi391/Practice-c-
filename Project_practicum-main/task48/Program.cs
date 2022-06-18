// Задача 48: Задайте двумерный массив размера m на n,
// каждый элемент в массиве находится по формуле: Amn = m+n.
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5



int[,] GetArray(int a, int b)
{
	int[,] array = new int[a, b];
	Random rndNum = new Random();
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			array[i, j] = rndNum.Next(10);
			
		}
	}
	return array;
}

void PrintArray (int[,]array)
{
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			Console.Write($"{ array [ i, j ] } " );
		}
		Console.WriteLine( );
	}
}
int[,] arr = GetArray(5 , 7);
PrintArray( arr );
