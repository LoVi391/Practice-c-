//Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.

string dayweek = Console.ReadLine();
if(dayweek == "1") Console.WriteLine("Понедельник");
else if (dayweek == "2") Console.WriteLine("Вторник");
else if (dayweek == "3") Console.WriteLine("Среда");
else if (dayweek == "4") Console.WriteLine("Четверг");
else if (dayweek == "5") Console.WriteLine("Пятница");
else if (dayweek == "6") Console.WriteLine("Суббота");
else if (dayweek == "7") Console.WriteLine("Воскресенье");
else Console.WriteLine("Ошибка ввода!");