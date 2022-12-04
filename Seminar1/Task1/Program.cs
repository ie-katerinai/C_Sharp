Console.WriteLine("Введите целое число");
int num = Convert.ToInt32(Console.ReadLine()); //преобразует введенную строку в число
int square = num * num;
// Console.WriteLine("Квадрат введенного числа равен " + square);
Console.WriteLine($"Квадрат введенного числа равен {square}");// Используем форматированны вывод

if (num > 9 && num < 100) // проверка на двузначное число
{
    Console.WriteLine("Вы ввели двузначное число");
}
while (num <= 15) // вывод всех чисел от введенного до 25
{
    Console.WriteLine($"после которого есть еще двузначное число {num} ");
    num++;
}
Console.WriteLine();