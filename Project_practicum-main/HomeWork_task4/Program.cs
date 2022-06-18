/*
Напишите программу, которая на вход принимает
число (N), а на выходе показывает все чётные
числа от 1 до N.
*/

Console.WriteLine("ввидите число N");
int N = int.Parse(Console.ReadLine());
int K=0, num=1;
// Console.Write("N = ");
N = Convert.ToInt16(Console.ReadLine());
 for (int i = 0; i < N; i++)
{
Console.Write("N" + i + " = ");
N = Convert.ToInt16(Console.ReadLine());
if (N % 2 == 0)
{
K++;
}
else
{
 
}
}
Console.WriteLine("Количество четных чисел равно {0}", +K);
Console.ReadKey();
{
}
