// Напишите программу, которая по заданному номеру четверти, показывает
// диапазон возможных координат точек в этой четверти (x и y).

void CheckChetv(int chet)
{
    if (chet == 1)
        Console.WriteLine("координаты x>0 и y>0");
    else if (chet == 2)
        Console.WriteLine("координаты x<0 и y>0");
    else if (chet == 3)
        Console.WriteLine("координаты x<0 и y<0");
    else if (chet == 4)
        Console.WriteLine("координаты x>0 и y<0");
    else
        Console.WriteLine("Вы ввели неправильный номер четверти");
}

try
{
    Console.WriteLine("Введите номер четверти (1-4)");
    int chet = Convert.ToInt32(Console.ReadLine());

    CheckChetv(chet);
}
catch
{
    Console.WriteLine("Вы ввели неправильный номер четверти!");
}
