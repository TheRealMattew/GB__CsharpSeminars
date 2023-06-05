// -----------------------------------------------------------------------------------------------------------------
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// -----------------------------------------------------------------------------------------------------------------
/*
Console.WriteLine("Задача 25. || Программа возводит, первое введенное число в степень, равную второму введенному числу. Второе число - натуральное!");

bool CheckInput(int number)
{
    bool answer = true;
    if (number <= 0 || number%1 != 0) answer = false;
    return answer;
}

double MyPower(double numb1, int numb2)
{
    double result = 1;
    for (int i = 1; i <= numb2; i++)
        {
            result = result *numb1;
        }
    return result;
}

Console.Write("Введите первое число: ");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите второе число (натуральное): ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (CheckInput(num2)) Console.WriteLine($"Ответ: {MyPower(num1, num2)}");
else
{
    Console.WriteLine("Введенные данные не соответствуют условию!");
}

// Можно было проще, учитывая, что уже использовали эту функцию...
// double result = Math.Pow(num1,num2);
// Console.WriteLine($"Ответ: {result}");
//*/


// -----------------------------------------------------------------------------------------------------------------
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// -----------------------------------------------------------------------------------------------------------------
/*
Console.WriteLine("Задача 27. || Программа вычисляет сумму цифр введенного целого числа.");

int SumOfNumerals(int numb)
{
    int result = 0;
    int inputNmb = Math.Abs(numb);

    while (inputNmb > 0)
    {
        result = result + inputNmb%10;
        inputNmb = inputNmb/10;
    }
    
    return result;
}

Console.WriteLine("Введите число:");
int inputNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Ответ: Сумма цифр введенного числа = {SumOfNumerals(inputNumber)}");
//*/


// -----------------------------------------------------------------------------------------------------------------
// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// -----------------------------------------------------------------------------------------------------------------
//*
Console.WriteLine("Задача 29. || Программа создает массив случайных чисел.");

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

Console.Write("Введите нужную длину массива: ");
int arrlength = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите мин значение: ");
int arrmin = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите макс значение: ");
int arrmax = Convert.ToInt32(Console.ReadLine());

int[] A = GenerateArray(arrlength, arrmin, arrmax);
PrintArray(A);

//*/