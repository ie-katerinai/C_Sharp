﻿// Напишите программу, которая принимает на вход число и проверяет, 
// кратно ли оно одновременно 7 и 23.
Console.Write("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

if (num1 % 7 == 0 && num1 % 23 == 0) Console.WriteLine($"Число {num1} кратно 7 и 23 одновременно! ");

else Console.WriteLine($"Число {num1} не кратно 7 и 23 одновременно!");
