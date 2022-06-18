// Задача 13: Напишите программу, которая выводит
// третью цифру заданного числа или сообщает, что третьей
// цифры нет.
// Примеры:
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите целое число -> ");
int anyNum = Convert.ToInt32(Console.ReadLine());
string anyNumText = Convert.ToString(anyNum);
if (anyNumText.Length > 2)
{
  Console.WriteLine("третья цифра из числа -> " + anyNumText[2]);
}
else 
{ 
    Console.WriteLine("третьей цифры нет");
}
	Console.WriteLine(anyNum);