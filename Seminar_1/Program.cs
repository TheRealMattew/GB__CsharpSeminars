﻿// -----------------------------------------------------------------------------------------------------------------
// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// -----------------------------------------------------------------------------------------------------------------
/*
Console.WriteLine("Задача 2. || Программа выдает большее и меньшее из 2х введенных чисел (десятичный разделитель ',').");
Console.Write("Введите первое число: ");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите второе число: ");
double num2 = Convert.ToDouble(Console.ReadLine());

if(num1 > num2)
{
    Console.WriteLine($"Наибольшее число = {num1}");
    Console.WriteLine($"Наименьшее число = {num2}");
}
else
{
    if(num1 < num2)
    {
        Console.WriteLine($"Наибольшее число = {num2}");
        Console.WriteLine($"Наименьшее число = {num1}");
    }
    else
    {
        Console.WriteLine($"Введенные числа равны между собой! Нельзя определить большее и меньшее между ними.");
    }
}
//*/


// -----------------------------------------------------------------------------------------------------------------
// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// -----------------------------------------------------------------------------------------------------------------
/*
Console.WriteLine("Задача 4. || Программа выдает наибольшее из 3х введенных чисел (десятичный разделитель ',').");
Console.Write("Введите первое число: ");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите второе число: ");
double num2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите третье число: ");
double num3 = Convert.ToDouble(Console.ReadLine());

double max = num1;
if(num2 > max) max = num2;
if(num3 > max) max = num3;

Console.WriteLine($"Наибольшее число = {max}");
//*/


// -----------------------------------------------------------------------------------------------------------------
// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// -----------------------------------------------------------------------------------------------------------------
/*
Console.WriteLine("Задача 6. || Программа определяет четность числа (десятичный разделитель ',').");
Console.Write("Введите число: ");
double num = Convert.ToDouble(Console.ReadLine());

double rem = num % 2;

if(rem == 0) Console.WriteLine("Введенное число - четное");
else Console.WriteLine("Введенное число - нечетное");
//*/


// -----------------------------------------------------------------------------------------------------------------
// Задача 8: Напишите программу, которая на вход принимает число N, а на выходе показывает все чётные числа от 1 до N.
// -----------------------------------------------------------------------------------------------------------------
//*
Console.WriteLine("Задача 8. || Программа выводит все четные числа от 1 до введенного числа (десятичный разделитель ',').");
Console.Write("Введите число: ");
double num = Convert.ToDouble(Console.ReadLine());

double counter = num/2;
counter = counter - counter%1;
int i = 1;
bool p = false;

if(counter > 0)
{
    Console.Write("Ответ:");
    while(i < counter)
    {
        Console.Write($" {i*2},");
        i++;
    }
    Console.Write($" {counter*2}.");
    p = true;
}

if(counter < 0)
{
    Console.Write("Ответ: 0,");
    while(i < -counter)
    {
        Console.Write($" {-i*2},");
        i++;
    }
    Console.Write($" {counter*2}.");
    p = true;
}

if(counter == 0 && num <= 0)
{
    Console.Write("Ответ: 0.");
    p = true;
}

if(p == false)
{
    Console.Write("Ответ: нет четных чисел в заданном промежутке.");
}
//*/