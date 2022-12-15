// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

//int N = new Random().Next(0, 20);

Console.WriteLine("Укажите размер массива");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine("Укажите нижнюю границу чисел для генерации массива");
int min = int.Parse(Console.ReadLine()!);

Console.WriteLine("Укажите верхнюю границу чисел для генерации массива");
int max = int.Parse(Console.ReadLine()!);

int[] arr = GenerateArray(N, min, max);

Console.WriteLine("Сгенерирован массив размером: " + N + " со случайными числами от " + min + " до " + max +".");

PrintArray(arr);

SumOddIndNum(arr);

void SumOddIndNum(int[] array)
{
    int sumOddIndexNum = 0;

    for (int i = 1; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            sumOddIndexNum += array[i];
        }
    }
    Console.WriteLine("Сумма элементов, стоящих на нечетных позициях: " + sumOddIndexNum);
}

int[] GenerateArray(int size, int minBorder, int maxBorder)
{
    int[] array = new int[size];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minBorder, maxBorder);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}