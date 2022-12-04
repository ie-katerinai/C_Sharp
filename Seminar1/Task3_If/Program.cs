// Напишите программу, которая будет выдавать название дня недели по заданному номеру
Console.WriteLine("Введите число от 1 до 7");
int num = Convert.ToInt32(Console.ReadLine());
string dayweek = "";//объявить как пустую строку
if (num > 0 && num < 8 )
{
    if (num == 1) dayweek = "Понедельник";
    if (num == 2) dayweek = "Вторник";
    if (num == 3) dayweek = "Среда";
    if (num == 4) dayweek = "Четверг";
    if (num == 5) dayweek = "Пятница";
    if (num == 6) dayweek = "Суббота";
    if (num == 7) dayweek = "Воскресенье";
    Console.Write("Соответствующий день недели ");
    Console.WriteLine(dayweek);
}   
else
{
    Console.WriteLine("Не корректное число ");
}
