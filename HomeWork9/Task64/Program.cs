﻿// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа
// в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


string PrintNumRec(int N)
{
    if (N == 0)
        return "";
    return Convert.ToString(N) + ", " + PrintNumRec(N - 1);
}

try
{
    Console.WriteLine("Введите целое число");
    int N = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($" {PrintNumRec(N)}");
}
catch (System.FormatException)
{
    Console.WriteLine("Некорректный ввод");
}