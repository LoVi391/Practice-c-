///Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке
//от M до N: 
//M=1, N=5:  1,2,3,4,5
//M=4, N=8:  4,5,6,7,8
Console.Clear();
Console.WriteLine(" введите число м");
int M = int.Parse(Console.ReadLine());
Console.WriteLine(" введите число N");
int N = int.Parse(Console.ReadLine());

NaturalNumber(M, N);
Console.ReadKey();

void NaturalNumber(int M, int N)
{
	if (M > N)
	{
			Console.Write(M + " ");
			
		NaturalNumber(M - 1, N);
		
	
	}
	if (M < N)
	{
		Console.Write(M + " ");
		
		NaturalNumber(M + 1, N);
		
		
	}
	if (M == N)  
	Console.Write(M);
}


