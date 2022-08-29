// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9-> (-0,5; -0,5)

Console.Write("Введите b1: ");
string? B1 = Console.ReadLine();
int b1 = int.Parse(B1);
Console.Write("Введите k1: ");
string? K1 = Console.ReadLine();
int k1 = int.Parse(K1);
Console.Write("Введите b2: ");
string? B2 = Console.ReadLine();
int b2 = int.Parse(B2);
Console.Write("Введите k2: ");
string? K2 = Console.ReadLine();
int k2 = int.Parse(K2);

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;


Console.WriteLine($"Точка пересечения: ({x}; {y})");

