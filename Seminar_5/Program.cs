// -----------------------------------------------------------------------------------------------------------------
// Задача 34:   Задайте массив заполненный случайными положительными трёхзначными числами.
//              Напишите программу, которая покажет количество чётных чисел в массиве.
// -----------------------------------------------------------------------------------------------------------------
/*
Console.WriteLine("Задача 34. || Программа показывает кол-во четных чисел в массиве случайных чисел");

int[] GenerateArray(int length, int minval, int maxval)
{
    int[] result = new int[length];
    for (int i = 0; i < length; i++)
    {
        result[i] = new Random().Next(minval, maxval+1);
    }
    return result;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int EvenNumberCounter(int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i]%2 == 0) result++;
    }
    return result;
}

Console.Write("Введите нужную длину массива: ");
int arrlength = Convert.ToInt32(Console.ReadLine());
//Console.Write("Введите мин значение: ");
int arrmin = 100;
//Console.Write("Введите макс значение: ");
int arrmax = 999;

int[] A = GenerateArray(arrlength, arrmin, arrmax);
PrintArray(A);
Console.WriteLine($"Ответ: {EvenNumberCounter(A)}");

//*/


// -----------------------------------------------------------------------------------------------------------------
// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// -----------------------------------------------------------------------------------------------------------------
/*
Console.WriteLine("Задача 36. || Программа вычисляет сумму элементов на нечетных позициях.");

int[] GenerateArray(int length, int minval, int maxval)
{
    int[] result = new int[length];
    for (int i = 0; i < length; i++)
    {
        result[i] = new Random().Next(minval, maxval+1);
    }
    return result;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int UnevenPositionSum(int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i = i+2)
    {
        result = result + arr[i];
    }
    return result;
}

Console.Write("Введите нужную длину массива: ");
int arrlength = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите мин значение: ");
int arrmin = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите макс значение: ");
int arrmax = Convert.ToInt32(Console.ReadLine());

int[] A = GenerateArray(arrlength, arrmin, arrmax);
PrintArray(A);
Console.WriteLine($"Ответ: {UnevenPositionSum(A)}");

//*/


// -----------------------------------------------------------------------------------------------------------------
// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// -----------------------------------------------------------------------------------------------------------------
//*
Console.WriteLine("Задача 38. || Программа находит разницу между максимальным и минимальным элементами массива.");

double[] GenerateArray(int length, int minval, int maxval)
{
    double[] result = new double[length];
    for (int i = 0; i < length; i++)
    {
        result[i] = new Random().Next(minval, maxval) + new Random().NextDouble();
    }
    return result;
}

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

double MaxMinDiff(double[] arr)
{
    double minval = arr[0];
    double maxval = arr[1];

    if(arr[0] > arr[1])
    {
        maxval = arr[0];
        minval = arr[1];
    }

    for (int i = 2; i < arr.Length; i++)
    {
        if(arr[i] > maxval) maxval = arr[i];
        if(arr[i] < minval) minval = arr[i];
    }

    double result = maxval - minval;
    return result;
}

Console.Write("Введите нужную длину массива: ");
int arrlength = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите мин значение: ");
int arrmin = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите макс значение: ");
int arrmax = Convert.ToInt32(Console.ReadLine());

double[] A = GenerateArray(arrlength, arrmin, arrmax);
PrintArray(A);
Console.WriteLine($"Ответ: {MaxMinDiff(A)}");

//*/