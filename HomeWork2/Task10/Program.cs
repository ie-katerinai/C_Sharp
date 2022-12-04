/*Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа. 
Через строку решать нельзя.
456 -> 5
782 -> 8
918 -> 1*/
Console.WriteLine("Введите трехзначное число");
try
{
    int num=Convert.ToInt32(Console.ReadLine());
    if (num < 0)
    {
        num = -num;
    }
    if (num > 99 && num < 1000)
    {
        int ten = (num / 10) % 10;
        Console.WriteLine($"Вторая цифра числа - это {ten}");
    }
    else Console.WriteLine("Вы ввели не трехзначное число");
}
catch
{
    Console.WriteLine("Вы  ввели не числовое значение");
}