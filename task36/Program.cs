// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] GenerateArray(int length, int minNum, int maxNum)
{
    int[] arr = new int[length];
    for (int i=0;i<arr.Length;i++)
    {
        arr[i] = new Random().Next(minNum, maxNum + 1);
    }
    return arr;
}

int CountSumOfNotEvenIndexes(int[] array)
{
    int result = 0;
    if (array.Length < 1) return result;
    for (int i=1;i<array.Length;i+=2)
    {
        result += array[i];
    }
    return result;
}

int[] myArray = GenerateArray(4, -100, 100);
int sumNonEvenIndexes = CountSumOfNotEvenIndexes(myArray);
Console.WriteLine($"Сгенерирован массив [{String.Join(", ", myArray)}], Сумма элементов нечётных индексов {sumNonEvenIndexes}.");

