// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.WriteLine(" Введите десятичное  число -> ");

int num = int.Parse(Console.ReadLine());
int[] count = new int[num];
for (int i = 0; num != 0; i++)
{

    count[i] = num % 2;
    num = num / 2;
    System.Console.Write(count[i]);
}
Array.Reverse(count);
System.Console.WriteLine($"{string.Join(' ', num)}");

