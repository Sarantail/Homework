// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4->да
// - 3->нет

Console.WriteLine("Введите число");
string? numberString = Console.ReadLine();
var number = int.Parse(numberString);

if (number % 2 == 0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}