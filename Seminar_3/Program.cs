// -----------------------------------------------------------------------------------------------------------------
// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// -----------------------------------------------------------------------------------------------------------------
/*
Console.WriteLine("Задача 19. || Программа проверяет, является ли введенное чило полиндромом.");
Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());

bool IfPalindrom(int num)
{
    num = Math.Abs(num);
    int NmbOfSign = 1;
    int tmp = num;

    while(tmp/10 > 0)
    {
        NmbOfSign++;
        tmp = tmp/10;
    }

    bool answer = true;
    if (NmbOfSign == 1) return answer;
  
    for (int i = 1; i <= NmbOfSign/2; i++)
    {
        int dec1 = (int)Math.Pow(10,i-1);
        int dec2 = (int)Math.Pow(10,NmbOfSign-i);

        int signfirst = (num/dec1)%10;
        int signsecond = (num/dec2)%10;
        if(signfirst != signsecond) answer = false;
    }

    return answer;
}

if (IfPalindrom(num)) Console.WriteLine("Ответ: Введенное число - палиндром");
else Console.WriteLine("Ответ: Введенное число не является палиндромом");
//*/


// -----------------------------------------------------------------------------------------------------------------
// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// -----------------------------------------------------------------------------------------------------------------
/*
Console.WriteLine("Задача 21. || Программа вычисляет расстояние между двумя точками c точностью до 0,01.");
Console.WriteLine("Последовательно введите координаты первой точки (x, y, z):");
double x1 = Convert.ToDouble(Console.ReadLine());
double y1 = Convert.ToDouble(Console.ReadLine());
double z1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Последовательно введите координаты второй точки (x, y, z):");
double x2 = Convert.ToDouble(Console.ReadLine());
double y2 = Convert.ToDouble(Console.ReadLine());
double z2 = Convert.ToDouble(Console.ReadLine());

double Distance3D(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double result = Math.Sqrt(Math.Pow(x1-x2,2) + Math.Pow(y1-y2,2) + Math.Pow(z1-z2,2));
    return result = Math.Round(result, 2);
}
Console.WriteLine($"Ответ: Расстояние между двумя точками равно: {Distance3D(x1,y1,z1,x2,y2,z2)}");
//*/


// -----------------------------------------------------------------------------------------------------------------
// Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// -----------------------------------------------------------------------------------------------------------------
//*
Console.WriteLine("Задача 23. || Программа выдает таблицу кубов от 1 до N при N >= 1.");
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

string TheRowOf3rd(int num)
{
    string result = "";
    if( num <= 0) return "Введенное число не удовлетворяет условию!";
    else
    {
        for (int i = 1; i < num; i++)
        {
            result = result + $"{i*i*i}" + ", ";
        }

    }
    return result = result + $"{num*num*num}" + ".";
}

Console.WriteLine("Ответ: " + TheRowOf3rd(num));
//*/