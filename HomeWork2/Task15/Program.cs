/*Задача 15. Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/
Console.WriteLine("Введите цифру дня недели");
try
{
    int num = Convert.ToInt32(Console.ReadLine());
    if (num > 0 && num < 8)
    {
        string day="";
        switch (num)
        {
            case 1: day="понедельник";
            break;
            case 2: day="вторник";
            break;
            case 3: day="среда";
            break;
            case 4: day="четверг";
            break;
            case 5: day="пятница";
            break;
            case 6: day="суббота";
            break;
            case 7: day="воскресенье";
            break;
        }
        Console.WriteLine($"День недели, который соответствует цифре {num} - это {day}");
    }
    else Console.WriteLine("Вы ввели некорректное число");
    if (num == 6 || num == 7) Console.WriteLine("выходной день");
    else Console.WriteLine("будний день");
   
}
catch 
{
    Console.WriteLine("Вы ввели не числовое значение");
}