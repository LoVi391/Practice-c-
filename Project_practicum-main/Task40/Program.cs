// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.


Console.WriteLine(" Введите целое число -> ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" Введите целое число -> ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" Введите целое число -> ");
int c = Convert.ToInt32(Console.ReadLine());

if (a < b + c && b < a + c && c < a + b)
{
    Console.WriteLine("Это может быть треугольник");
}

