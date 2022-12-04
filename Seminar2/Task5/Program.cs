// Напишите программу, которая принимает на вход два числа и проверяет, 
// является ли одно число квадратом другого.

Console.WriteLine("Введите два числа");
Console.WriteLine("введите число 1");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число 2");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 == num2*num2)
Console.WriteLine($"Число {num2} является квадратом числа {num1}.");
else
Console.WriteLine($"Число {num2} не является квадратом числа {num1}.");
if (num2 == num1*num1)
Console.WriteLine($"Число {num1} является квадратом числа {num2}.");
else
Console.WriteLine($"Число {num1} не является квадратом числа {num2}.");



/*Console.WriteLine("введите число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1==num2*num2)
Console.WriteLine($"{num1} является квадратом {num2}");
else if (num2==num1*num1)
Console.WriteLine($"{num2} является квадратом {num1}");
else
Console.WriteLine("не являются квадратами друг друга");*/