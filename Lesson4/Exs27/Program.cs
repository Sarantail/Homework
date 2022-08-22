// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452-> 11
// 82-> 10
// 9012-> 12

Console.WriteLine("Введите число");
string? numberString = Console.ReadLine();
var SumNum = int.Parse(numberString);

int result = 0;

while (SumNum > 0)
{
    int num = SumNum % 10;
    SumNum = SumNum / 10;
    result = result + num;
}

Console.WriteLine(result);