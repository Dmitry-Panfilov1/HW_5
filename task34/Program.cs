// Задайте массив заполненный случайными положительными трехзначными числами. Напишите программу, которая покажет количество четных чисел в массиве.

Console.WriteLine("Укажите размер массива");
int N = int.Parse(Console.ReadLine()!);

//int N = new Random().Next(0, 20); 

int min = 99;
//Console.WriteLine("Укажите нижнюю границу чисел для генерации массива");
//int min = int.Parse(Console.ReadLine()!);

int max = 1000;
//Console.WriteLine("Укажите верхнюю границу чисел для генерации массива");
//int max = int.Parse(Console.ReadLine()!);

int[] arrayThreeDigNum = GenerateArray(N, min, max);

Console.WriteLine("Сгенерирован массив размером: " + N + " со случайными числами от " + min + " до " + max +".");

PrintArray(arrayThreeDigNum);

CountEvenNumber(arrayThreeDigNum);

void CountEvenNumber(int[] array)
{
    int countEvenNumber = 0;

    for (int i = 0; i < array.Length; i++)
    {   
        if (array[i] % 2 == 0)
        {
            countEvenNumber++;
        }
    }
    Console.WriteLine("Количество четных чисел в массиве: " + countEvenNumber);
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