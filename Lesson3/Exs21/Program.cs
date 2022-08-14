﻿// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B(2, 1, -7), -> 15.84
// A(7, -5, 0); B(1, -1, 9)-> 11.53

Console.WriteLine("Введите координату X точки A:");
string? numberXAstring = Console.ReadLine();
int numberXA = int.Parse(numberXAstring!);
Console.WriteLine("Введите координату Y точки A:");
string? numberYAstring = Console.ReadLine();
int numberYA = int.Parse(numberYAstring!);
Console.WriteLine("Введите координату Z точки A:");
string? numberZAstring = Console.ReadLine();
int numberZA = int.Parse(numberZAstring!);

Console.WriteLine("Введите координату X точки B:");
string? numberXBstring = Console.ReadLine();
int numberXB = int.Parse(numberXBstring!);
Console.WriteLine("Введите координату Y точки B:");
string? numberYBstring = Console.ReadLine();
int numberYB = int.Parse(numberYBstring!);
Console.WriteLine("Введите координату Z точки B:");
string? numberZBstring = Console.ReadLine();
int numberZB = int.Parse(numberZBstring!);

double numberXX = numberXB - numberXA;
double numberYY = numberYB - numberYA;
double numberZZ = numberZB - numberZA;
double result = (double)Math.Sqrt((numberXX * numberXX) + (numberYY * numberYY) + (numberZZ * numberZZ));
Console.WriteLine("Расстояние между точками А и В равно: " + result.ToString("N2") + ".");