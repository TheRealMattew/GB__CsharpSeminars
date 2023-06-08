// -----------------------------------------------------------------------------------------------------------------
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// -----------------------------------------------------------------------------------------------------------------
/*
Console.WriteLine("Задача 41. || Программа считает сколько из введенных чисел/знаков совпадают с нулём");

int CountZeros(string inptext)
{
    int result = 0;
    char zero = '0';
    for (int i = 0; i < inptext.Length; i++)
    {
        if(String.Equals(inptext[i], zero)) result++;
    }
    return result;
}

Console.Write("Введите строку чисел: ");
string text = Console.ReadLine();

int A = CountZeros(text);
Console.WriteLine($"Ответ: В тексте содержится {A} нулей");

//*/


// -----------------------------------------------------------------------------------------------------------------
// Задача 43:   Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
//              y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// -----------------------------------------------------------------------------------------------------------------
//*
Console.WriteLine("Задача 43. || Программа вычисляет координату точки пересечения двух прямых.");

double[] LinesCrossection(double k1, double b1, double k2, double b2)
{
    double[] result = new double[2];

    result[0] = (b1 - b2) / (k2 - k1);
    result[1] = k1 * (b1 - b2) / (k2 - k1) + b1;

    return result;
}

bool CheckInput(double k1, double b1, double k2, double b2)
{
    bool result = true;
    
    if(k1 == k2 && b1 == b2)
    {
        result = false;
        Console.WriteLine("Прямые совпадают!");
    }

    if(k1 == k2 && result)
    {
        result = false;
        Console.WriteLine("Прямые параллельны!");
    }

    return result;
}

Console.Write("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

if(CheckInput(k1, b1, k2, b2))
{
    double[] Crds = LinesCrossection(k1, b1, k2, b2);
    Console.WriteLine($"Ответ: ({Crds[0]}; {Crds[1]})");
}

//*/