// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// для вещественных чисел использую double

double[] GenerateArray(int length, int minNum, int maxNum)
{
    double[] arr = new double[length];
    for (int i=0;i<arr.Length;i++)
    {
        double rDouble = new Random().NextDouble();
        arr[i] = new Random().Next(minNum, maxNum) + rDouble;
    }
    return arr;
}

int[] FindIndexOfMinAndMaxElements(double[] array)
{
    int[] result = new int[] {0, 0};
    for (int i=1;i<array.Length;i++)
    {
        if (array[i] < array[result[0]])
        {
            result[0] = i;
        }
        if (array[i] > array[result[1]])
        {
            result[1] = i;
        }
    }
    return result;
}

double[] myArray = GenerateArray(4, -100, 100);
int[] minMaxIndexes = FindIndexOfMinAndMaxElements(myArray);
Console.WriteLine($"Сгенерирован массив [{String.Join(", ", myArray)}],");
Console.WriteLine($"Минимальное число {myArray[minMaxIndexes[0]]}, Максимальное число {myArray[minMaxIndexes[1]]}");
Console.WriteLine($"Разница максимального и минимального равна {myArray[minMaxIndexes[1]] - myArray[minMaxIndexes[0]]}");
