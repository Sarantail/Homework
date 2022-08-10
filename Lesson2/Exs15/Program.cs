// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите номер дня недели");
string? numberString = Console.ReadLine();
var number = int.Parse(numberString);

if (number >= 6)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
