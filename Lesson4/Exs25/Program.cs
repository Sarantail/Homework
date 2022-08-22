// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5-> 243(3⁵)
// 2, 4-> 16

Console.WriteLine("Введите число A");
string? numberString1 = Console.ReadLine();
var A = int.Parse(numberString1);

Console.WriteLine("Введите число B");
string? numberString2 = Console.ReadLine();
var B = int.Parse(numberString2);

int result = A;
for (int i = 1; i < B; i++)
{
    result = result * A;
}
Console.WriteLine(result);