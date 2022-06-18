/* 
Решение в группах задач:
Задача 26: Напишите программу, которая принимает
на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/


Console.WriteLine("Введите число :");
int n = int.Parse(Console.ReadLine());
int count = 0;
while (n > 0)
{
    n = n/10;
    count = count++;
}
Console.WriteLine(count);







