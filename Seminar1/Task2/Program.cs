// Напишите программу, которая на входе принимает два числа и проверяет, является ли первое квадратом второго
Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num2 == num1 * num1)
{
    Console.WriteLine("Первое число является квадратом второго");
}
Console.WriteLine("Первое число не является квадратом второго");