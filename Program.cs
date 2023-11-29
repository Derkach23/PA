// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

/* using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите значение N: ");
        int N = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(GetNaturalNumbers(N));
    }

    static string GetNaturalNumbers(int n)
    {
        if (n == 1)
        {
            return "1";
        }
        else
        {
            return n + ", " + GetNaturalNumbers(n - 1);
        }
    }
} */

// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

/* using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите M: ");
        int m = int.Parse(Console.ReadLine());
        
        Console.Write("Введите N: ");
        int n = int.Parse(Console.ReadLine());
        
        int sum = 0;
        for (int i = m; i <= n; i++)
        {
            sum += i;
        }
        
        Console.WriteLine($"M = {m}; N = {n} -> {sum}");
    }
} */

// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

/* using System;
class AckermannFunction
{
    static int Ackermann(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (n == 0)
        {
            return Ackermann(m - 1, 1);
        }
        else
        {
            return Ackermann(m - 1, Ackermann(m, n - 1));
        }
    }
    static void Main()
    {
        Console.Write("Введите число m: ");
        int m = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите число n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int result = Ackermann(m, n);
        Console.WriteLine("Функция Аккермана для m = " + m + " и n = " + n + " равна " + result);
    }
} */