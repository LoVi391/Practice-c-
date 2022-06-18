// Задача 19: Напишите программу, которая принимает на
// вход пятизначное число и проверяет, является ли оно
// палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да


Console.WriteLine(" Введите пятизначное число -> ");
string num1 = Console.ReadLine();
char[] arr = num1.ToCharArray();
Array.Reverse(arr);
string num2 = new String(arr);

if (num1 == num2) Console.WriteLine("Да");
else Console.WriteLine("Нет");