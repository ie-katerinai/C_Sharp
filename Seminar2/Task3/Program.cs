// Задача 12. Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
Console.WriteLine("Введите два числа");
Console.WriteLine("введите число 1");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число 2");
int num2 = Convert.ToInt32(Console.ReadLine());
int div = num2 % num1;
if (div !=0) // if (num1 % num2 ==0)
{
    Console.WriteLine($"Число {num2} не кратно числу {num1}. Остаток равен = {div}");
}
else
Console.WriteLine($"Число {num2}  кратно числу {num1}.");

