// -----------------------------------------------------------------------------------------------------------------
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// -----------------------------------------------------------------------------------------------------------------
/*
Console.WriteLine("Задача 47. || Программа создает и заполняет двумерный массив");

double[,] Generate2DArray(int rows, int columns, int minval, int maxval)
{
    double[,] result = new double[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = Math.Round(new Random().Next(minval, maxval) + new Random().NextDouble(), 2);
        }
    }
    return result;
}

void Print2DArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Введите кол-во строк: ");
int arrRows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int arrColumns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите мин значение: ");
int arrMin = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите макс значение: ");
int arrMax = Convert.ToInt32(Console.ReadLine());

double[,] A = Generate2DArray(arrRows, arrColumns, arrMin, arrMax);
Print2DArray(A);

//*/


// -----------------------------------------------------------------------------------------------------------------
// Задача 50.   Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает
//              значение этого элемента или же указание, что такого элемента нет.
// -----------------------------------------------------------------------------------------------------------------
/*
Console.WriteLine("Задача 50. || Программа выдает значение элемента двумерного массива по введенной позиции.");

double[,] Generate2DArray(int rows, int columns, int minval, int maxval)
{
    double[,] result = new double[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = Math.Round(new Random().Next(minval, maxval) + new Random().NextDouble(), 2);
        }
    }
    return result;
}

void Print2DArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}   ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void PrintValueByPosition(double[,] arr, int nRow, int nCol)
{
    if(nRow > arr.GetLength(0)-1 || nRow < 0 || nCol > arr.GetLength(1)-1 || nCol < 0)
    {
        Console.WriteLine("Запрашиваемое положение лежит вне диапазона матрицы");
    }
    else
    {
        Console.WriteLine($"Ответ: {arr[nRow, nCol]}");
    }

}

double[,] A = Generate2DArray(5, 5, -6, 20);
Console.WriteLine("Дан двумерный массив: ");
Print2DArray(A);
Console.Write("Введите строку: ");
int arrRow = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите столбец: ");
int arrColumn = Convert.ToInt32(Console.ReadLine());
PrintValueByPosition(A, arrRow, arrColumn);

//*/


// -----------------------------------------------------------------------------------------------------------------
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// -----------------------------------------------------------------------------------------------------------------
//*
Console.WriteLine("Задача 52. || Программа находит среднее арифметическое каждого столбца массива.");


int[,] Generate2DArray(int rows, int columns, int minval, int maxval)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(minval, maxval+1);
        }
    }
    return result;
}

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}   ");
    }
    Console.WriteLine();
}

void Print2DArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}   ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

double[] MeanValuesForEachColumn(int[,] arr)
{
    double[] result = new double[arr.GetLength(1)];
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        int sum = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            sum = sum + arr[i, j]; 
        }
        //result[j] = Math.Round(Convert.ToDouble(sum)/Convert.ToDouble(arr.GetLength(0)),2);
        result[j] = Math.Round((double) sum / arr.GetLength(0), 2);
    }
    return result;
}

int[,] A = Generate2DArray(6, 5, -6, 20);
Console.WriteLine("Дан двумерный массив: ");
Print2DArray(A);
double[] Amean = MeanValuesForEachColumn(A);
Console.Write("Ответ: ");
PrintArray(Amean);

//*/