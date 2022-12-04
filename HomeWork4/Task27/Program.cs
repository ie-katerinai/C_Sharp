﻿// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Через строку решать нельзя.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumDigit(int num) // функция, которая ищет сумму цифр числа
{
    if (num < 0) num = -num; // если ввеено отрицательное числоБ то елаем его положительным
    int sum = 0; // изначально сумма равна 0
    while (num != 0) // условие, при котором прекращается выполнение цикла
    {
        int digit = num % 10; // отделяем посленюю цифру от числа и записываем его в переменную
        sum += digit; // находим сумму цифр
        num = num / 10; // отеляем разря еиниц у числа
    }
    return sum;
}

try
{
    Console.WriteLine("Введите число А"); // вывод запроса пользователю
    int N = Convert.ToInt32(Console.ReadLine()); // конвертирование и запись значения в переменную
    Console.WriteLine($"Cумма цифр числа равна {SumDigit(N)}");
}
catch (System.FormatException) // ищет неверный формат ввоа
{
    Console.WriteLine("Вы ввели не натуральное число"); 
}