// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число");
string? numberString = Console.ReadLine();
var number = int.Parse(numberString);

if (number / 100 > 0)
{
    int first = number % 10;
    Console.WriteLine(first);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}
