// Console.Clear();
// onsole.SetCursorPosition(10, 4);
// Console.WriteLine("+");
Console.Clear();

int xa = 40, ya = 1,
    xb = 1, yb = 30,
    xc = 80, yc = 30;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");
Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");
Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

int x = xa, y = xb; // определит точку и положит в нее значения координат

int count = 0; // счетчик того, сколько раз будет делиться отрезок пополам

while (count < 10000)
{
    int whot = new Random().Next(0, 3); // генератор случайных чисел: [0; 3) - будут взяты числа 0, 1, 2
    if (whot == 0) // проверка
    {
        x = (x + xa)/2; // середина отрезка по х
        y = (y + ya)/2; // середина отрезка по у
    }
    if (whot == 1) // проверка
    {
        x = (x + xb)/2; // середина отрезка по х
        y = (y + yb)/2; // середина отрезка по у
    }
    if (whot == 2) // проверка
    {
        x = (x + xc)/2; // середина отрезка по х
        y = (y + yc)/2; // середина отрезка по у
    }
    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count = count + 1; // count +=1 count++
}