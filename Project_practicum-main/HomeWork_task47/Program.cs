// Задача 47: Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();
Console.WriteLine("Введите число m ->  ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число n ->  ");
int n = int.Parse(Console.ReadLine());

double[,] GetArray = new double[m, n];
Random rnd = new Random();
MakeArrDouble(GetArray);
void MakeArrDouble(double[,] array)
{
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			array[i, j] = rnd.NextDouble() * 20 - 10;
			Console.WriteLine("{0,6:F2}", array[i, j]);
		}
	}
	void PrintArray(double[,] array)
	{
		for (int i = 0; i < array.GetLength(0); i++)
		{
			for (int j = 0; j < array.GetLength(1); j++)
			{
				Console.WriteLine($"{array[i, j]} ");
			}
		}
	}
	void WriteArray(double[,] array)
	{
		for (int i = 0; i < m; i++)
		{
			for (int j = 0; j < n; j++)
			{
				double alignNumber = Math.Round(array[i, j], 1);
				Console.WriteLine(alignNumber + " ");
			}
			Console.WriteLine();
		}
	  	
		WriteArray(array);
		PrintArray(GetArray);
	
		Console.ReadKey();
	}
}




