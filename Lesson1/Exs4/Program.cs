// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите первое число");
string? numberString1 = Console.ReadLine();
var number1 = int.Parse(numberString1);

Console.WriteLine("Введите второе число");
string? numberString2 = Console.ReadLine();
var number2 = int.Parse(numberString2);

Console.WriteLine("Введите третье число");
string? numberString3 = Console.ReadLine();
var number3 = int.Parse(numberString3);

if (number1 > number2)
{
    if (number1 > number3)
    {
        Console.WriteLine(number1);
    }
    else
    {
        Console.WriteLine(number3);
    }
}
else
{
    if (number2 > number3)
    {
        Console.WriteLine(number2);
    }
    else
    {
        Console.WriteLine(number3);
    }
}
