// Задача 15: Напишите программу, которая принимает на
// вход цифру, обозначающую день недели, и проверяет,
// является ли этот день выходным.
// Примеры:
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введи цифру дня недели -> ");
int weekDayNum = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek(int weekDayNum)

{

	if (weekDayNum == 6 || weekDayNum == 7)

	{
		Console.WriteLine("(этот день выходной) -> да");
	}
	else
	{
		Console.WriteLine("(этот день не выходной) -> нет");
	}

}

CheckingTheDayOfTheWeek(weekDayNum);
