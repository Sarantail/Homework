// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

Console.Write("Введите M чисел: ");
int[] M = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
int count = 0;

for (int i = 0; i < M.Length; i++)
{
    if (M[i] > 0)
    {
        count++;
    }
}

Console.WriteLine($"Кол-во элементов больше 0: {count}");