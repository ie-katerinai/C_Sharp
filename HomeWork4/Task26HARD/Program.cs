// Задача 26. - HARD необязательная 
// Напишите программу, которая принимает на вход целое или дробное число и выдаёт количество цифр в числе.
// 452 -> 3
// 82 -> 2
// 9,012 ->4

Console.WriteLine("Введите число "); // вывод запроса пользователю
decimal N = Convert.ToDecimal(Console.ReadLine()); // конвертирование и запись значения в переменную

decimal fraction = N % 1;
int integer = Convert.ToInt32(N - fraction);

Console.WriteLine($"Целая часть {integer} равна , дробная часть равна {fraction}");