// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6]-> 0

int[] createArray()
{
    int[] array = new int[10];
    var random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(0, 100);
    }
    return array;
}

int searchNumbers(int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i = i + 2)
    {
        result += 1;
    }
    return result;
}

void viewArr(int[] arr)
{
    string result = "[";
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
        {
            result += arr[i] + ", ";
        }
        if (i == arr.Length - 1)
        {
            result += arr[i] + "]";
        }
    }
    Console.WriteLine(result);
}

int[] array = createArray();
viewArr(array);
Console.WriteLine(searchNumbers(array));