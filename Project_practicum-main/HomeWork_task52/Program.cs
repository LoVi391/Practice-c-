// // Задача 52: Задайте двумерный массив из целых чисел.
// // Найдите среднее арифметическое элементов в каждом
// // столбце.
// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // Среднее арифметическое каждого
// // столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();

void FillArray(double[,] matr)
{
	for (int i = 0; i < matr.GetLength(0); i++)
	{
		for (int j = 0; j < matr.GetLength(1); j++)
		{
			matr[i, j] = new Random().Next(1, 10);
		}
	}
}

void FindMidleArithmetic(double[,] arr, double midleArithmetic = 0)

 {
	
	for (int i = 0; i < arr.GetLength(0); i++)
	{
		
		for (int j = 0; j < arr.GetLength(1); j++)
  {
    midleArithmetic += arr[j, i];
  }
 
 Console.WriteLine($"Cреднее арифметическое элементов столбца {i + 1} = {(float)midleArithmetic/10}");
}

}

void PrintArray(double[,] array)
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


double[,] matrix = new double[10, 10];

FillArray(matrix);
FindMidleArithmetic(matrix);
PrintArray(matrix);

