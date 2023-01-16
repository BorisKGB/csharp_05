// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] GenerateArray(int length, int minNum, int maxNum)
{
    int[] arr = new int[length];
    for (int i=0;i<arr.Length;i++)
    {
        arr[i] = new Random().Next(minNum, maxNum + 1);
    }
    return arr;
}

int CountEvenNumbers(int[] arr)
{
    int result = 0;
    for (int i=0;i<arr.Length;i++)
    {
        if (arr[i] % 2 == 0)
        {
            result += 1;
        }
    }
    return result;
}

int[] myArray = GenerateArray(4, 0, 100);
int evenNumbers = CountEvenNumbers(myArray);
Console.WriteLine($"Сгенерированный массив [{String.Join(", ", myArray)}] содержит {evenNumbers} чётных чисел");
