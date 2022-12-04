/* Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.Через строку решать нельзя.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

Console.WriteLine("Введите целое число");
try
{
    int num = Convert.ToInt32(Console.ReadLine());
    if (num < 0)
    {
        num = -num;
    }
    if (Math.Log10(num) + 1 < 3)
    {
        Console.WriteLine("Третья цифра в числе отсутствует");
    }
    else 
    {
        while (Math.Log10(num) + 1 > 4)
        {
            num = num / 10;
        }
        Console.WriteLine($"Третья цифра числа: {num % 10}");
    }
}
catch 
{
    Console.WriteLine("Вы ввели не числовое значение");
}
