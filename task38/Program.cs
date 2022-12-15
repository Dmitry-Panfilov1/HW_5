// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

Console.WriteLine("Укажите размер массива");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine("Укажите нижнюю границу чисел для генерации массива");
double min = double.Parse(Console.ReadLine()!);

Console.WriteLine("Укажите верхнюю границу чисел для генерации массива");
double max = double.Parse(Console.ReadLine()!);

double[] arr = GenerateDoubleArray(N, min, max);

PrintArray(arr);

diffMinMaxNum(arr);

void diffMinMaxNum(double[] array)
{   
    double maxNum = array[0];
    double minNum = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        

        if (array[i] > maxNum)
        {
            maxNum = array[i];
        }
        else if (array[i] < minNum)
        {
            minNum = array[i];
        }
    }
    double diffNum = maxNum - minNum;

    Console.WriteLine("Разница между максимальным и минимальным элементами массива = " + diffNum);
}

double[] GenerateDoubleArray(int size, double minBorder, double maxBorder)
{
    double[] array = new double[size];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(new Random().NextDouble() * (maxBorder - minBorder) + minBorder, 3);
    }
    return array;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}