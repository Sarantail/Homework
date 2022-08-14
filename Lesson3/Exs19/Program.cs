// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число");
string? numberString = Console.ReadLine();
var number = int.Parse(numberString);

int four = number % 10;
int one = (number % 10000) / 1000;
int three = (number % 100) / 10;

if (number > 9999 && number < 100000)
{
    if (number / 10000 == four || one == three)
    {
        Console.WriteLine("Да");
    }
    else Console.WriteLine("Нет");
}
else
{
    Console.WriteLine("Ошибка. Введите пятизначное число");
}
