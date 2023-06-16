﻿// -----------------------------------------------------------------------------------------------------------------
// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// -----------------------------------------------------------------------------------------------------------------
/*
Console.WriteLine("Задача 64. || Программа выводит все натуральные числа от введенного числа до 1.");

void NumbersFromNto1(int N)
{
    if(N > 0)
    {
        Console.Write($"{N} ");
        NumbersFromNto1(N-1);
    }

}

Console.Write("Введите натуральное число N: ");
int initialNumber = Convert.ToInt32(Console.ReadLine());

if(initialNumber <= 0)
{
    Console.WriteLine("Введенное число не натуральное!");
}
else
{
    NumbersFromNto1(initialNumber);
}

//*/


// -----------------------------------------------------------------------------------------------------------------
// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// -----------------------------------------------------------------------------------------------------------------
/*
Console.WriteLine("Задача 66. || Программа находит сумму натуральных чисел в промежутке [M; N]");

int result = 0;

int SumNumbersFromMtoN(int M, int N)
{
    if(M <= N)
    {
        result = result + M;
        SumNumbersFromMtoN(M+1, N);
    }
    return result;
}

Console.Write("Введите натуральное число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число N: ");
int N = Convert.ToInt32(Console.ReadLine());

if(M > N)
{
    Console.WriteLine($"Ответ: Недопустимый интервал!");
}
else
{
    int R = SumNumbersFromMtoN(M, N);
    Console.WriteLine($"Ответ: {R}");
}

//*/


// -----------------------------------------------------------------------------------------------------------------
// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// -----------------------------------------------------------------------------------------------------------------
//*
Console.WriteLine("Задача 68. || Программа вычисляет функцию Аккермана для неотрицательных чисел m и n.");

int Akkerman(int m, int n)
{
    if(m == 0)
    {
        return n+1;
    }
    else
    {
        if(n == 0)
        {
            return Akkerman(m-1, 1);
        }
        else
        {
            return Akkerman(m-1, Akkerman(m, n-1));
        }
    }
}

Console.Write("Введите натуральное число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число n: ");
int n = Convert.ToInt32(Console.ReadLine());

int R = Akkerman(m, n);
Console.WriteLine($"Ответ: {R}");

//*/