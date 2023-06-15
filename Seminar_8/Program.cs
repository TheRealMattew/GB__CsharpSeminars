// -----------------------------------------------------------------------------------------------------------------
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// -----------------------------------------------------------------------------------------------------------------
/*
Console.WriteLine("Задача 54. || Программа упорядочит по убыванию каждую строку массива");

int[,] Generate2DArray(int rows, int columns, int minval, int maxval)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(minval, maxval + 1);
        }
    }
    return result;
}

// int[] GenerateArray(int length, int minval, int maxval)
// {
//     int[] result = new int[length];
//     for (int i = 0; i < length; i++)
//     {
//         result[i] = new Random().Next(minval, maxval+1);
//     }
//     return result;
// }

void Print2DArray(int[,] arr)
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

// void PrintArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write($"{arr[i]} ");
//     }
//     Console.WriteLine();
// }

void QuickSortOneRow(int[] array, int pos1, int pos2)
{
    if(pos1 < pos2)
    {
        int meanVal = array[pos2];
        int lessVal = pos1;
        int temp = 0;
        for(int i = pos1; i < pos2; i++)
        {
            if(array[i] >= meanVal)
            {
                temp = array[i];
                array[i] = array[lessVal];
                array[lessVal] = temp;
                lessVal++;
            }
        }
        temp = array[pos2];
        array[pos2] = array[lessVal];
        array[lessVal] = temp;

        QuickSortOneRow(array, pos1, lessVal-1);
        QuickSortOneRow(array, lessVal+1, pos2);
    }
}


void SortMaxToMinEachRow(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int[] arrRow = new int[arr.GetLength(1)];
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arrRow[j] = arr[i, j];
        }
        QuickSortOneRow(arrRow, 0, arrRow.Length-1);
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = arrRow[j];
        }
    }
}

Console.Write("Введите кол-во строк: ");
int arrRows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int arrColumns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите мин значение: ");
int arrMin = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите макс значение: ");
int arrMax = Convert.ToInt32(Console.ReadLine());

int[,] A = Generate2DArray(arrRows, arrColumns, arrMin, arrMax);
//int[] B = GenerateArray(arrRows, arrMin, arrMax);
Console.WriteLine();
Console.WriteLine("Исходный массив:");
Print2DArray(A);
SortMaxToMinEachRow(A);
Console.WriteLine("Преобразованный массив:");
Print2DArray(A);
//*/


// -----------------------------------------------------------------------------------------------------------------
// Задача 56:   Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей
//              суммой элементов.
// -----------------------------------------------------------------------------------------------------------------
/*
Console.WriteLine("Задача 56. || Программа находит строку с наименьшей суммой элементов");

int[,] Generate2DArray(int rows, int columns, int minval, int maxval)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(minval, maxval + 1);
        }
    }
    return result;
}

void Print2DArray(int[,] arr)
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

int SearchMinRowSum(int[,] arr)
{
    int[] RowSumArray = new int[arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            RowSumArray[i] = RowSumArray[i] + arr[i, j];
        }
    }
    int minVal = RowSumArray[0];
    int result = 0;
    for (int i = 1; i < arr.GetLength(0); i++)
    {
        if(RowSumArray[i] < minVal)
        {
            result = i;
            minVal = RowSumArray[i];
        }
    }
    return result;
}

Console.Write("Введите кол-во строк: ");
int arrRows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int arrColumns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите мин значение: ");
int arrMin = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите макс значение: ");
int arrMax = Convert.ToInt32(Console.ReadLine());

int[,] A = Generate2DArray(arrRows, arrColumns, arrMin, arrMax);
Console.WriteLine();
Console.WriteLine("Исходный массив:");
Print2DArray(A);
int m = SearchMinRowSum(A);
Console.WriteLine($"Ответ: Строка номер {m}");
//*/


// -----------------------------------------------------------------------------------------------------------------
// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// -----------------------------------------------------------------------------------------------------------------
//*
Console.WriteLine("Задача 58. || Программа находит произведение двух матриц.");


int[,] Generate2DArray(int rows, int columns, int minval, int maxval)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(minval, maxval + 1);
        }
    }
    return result;
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

int[,] MatrixMultiplication(int[,] X, int[,] Y)
{
    int[,] result = new int[X.GetLength(0), Y.GetLength(1)];
    if(X.GetLength(1) != Y.GetLength(0))
    {
        Console.WriteLine("Матрицы такого размера нельзя перемножить");
        return result;
    }

    for (int i = 0; i < X.GetLength(0); i++)
    {
        for (int j = 0; j < Y.GetLength(1); j++)
        {
            for (int k = 0; k < X.GetLength(1); k++)
            {
                result[i,j] = result[i,j] + X[i,k] * Y[k,j];
            }
        }
    }
    return result;
}

int[,] A = Generate2DArray(2, 2, 0, 9);
int[,] B = Generate2DArray(2, 3, 0, 2);
Console.WriteLine();
Console.WriteLine("Исходные массивы:");
Print2DArray(A);
Print2DArray(B);
int[,] R = MatrixMultiplication(A, B);
Console.WriteLine("Ответ:");
Print2DArray(R);
//*/