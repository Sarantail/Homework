// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

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

int searchMaximum(int[] arr)
{
    int maximum = arr[0];
    for (int i = 0; i < arr.Length; i = i + 1)
    {
        if (arr[i] > maximum)
        {
            maximum = arr[i];
        }
    }
    return maximum;
}
int searchMinimum(int[] arr)
{
    int minimum = arr[0];
    for (int i = 0; i < arr.Length; i = i + 1)
    {
        if (arr[i] < minimum)
        {
            minimum = arr[i];
        }
    }
    return minimum;
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
Console.WriteLine(searchMaximum(array) - searchMinimum(array));