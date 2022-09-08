// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15-> 120
// M = 4; N = 8. -> 30

int PrintSummNumber(int m, int n)
{
    int res = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        res = m + PrintSummNumber(m, n);
        return res;
    }
}

int m = 4;
int n = 8;

Console.Write(PrintSummNumber(m - 1, n));

PrintSummNumber(m, n);