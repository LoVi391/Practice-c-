// На входе число N
// на выходе показать промежутки от -N до N

Console.WriteLine("ввведите целое число");
int N = int.Parse(Console.ReadLine());
int Y = -N; 
while(Y <= N )
{
	Console.Write(Y+" ");
	Y++;
}

