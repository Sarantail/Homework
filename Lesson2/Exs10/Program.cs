// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число");
string? numberString = Console.ReadLine();
var number = int.Parse(numberString);

int first = number % 100;
int second = first / 10;

Console.WriteLine(second);