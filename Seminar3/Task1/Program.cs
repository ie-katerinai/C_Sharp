// Напишите программу, 
//которая принимает на вход координаты точки (X и Y), 
//причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, 
//в которой находится эта точка.


void CheckKoord(int x, int y)

{
if (x > 0 && y > 0) Console.WriteLine("Это четверть № 1");
else if (x > 0 && y < 0) Console.WriteLine("Это четверть № 4");
else if (x < 0 && y > 0) Console.WriteLine("Это четверть № 2");
else if (x < 0 && y < 0) Console.WriteLine("Это четверть № 3");
else Console.WriteLine("точна находится на координатной оси");
}
try
{
    Console.WriteLine("Введите координату Х");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координату Y");
    int y = Convert.ToInt32(Console.ReadLine());
    CheckKoord(x,y);
}

catch
{
    Console.WriteLine("Надо было вводить именно целые числа!");
}
