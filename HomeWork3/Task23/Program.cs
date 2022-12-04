/* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

/*try
{
    Console.WriteLine("Введите число");
    int N = Convert.ToInt32(Console.ReadLine());
    if (N == 0)
    {
        Console.WriteLine($"Куб числа {N} равен 0");
    }
    else if (N < 0)
    {
        for (int n = N; n <= 1; n++)
        {
            int num = (n * n * n);
            Console.WriteLine($"Куб числа {n} равен: {num}");
        }
    }
    else
    {
        for (int n = 1; n <= N; n++)
        {
            int num = (n * n * n);
            Console.WriteLine($"Куб числа {n} равен: {num}");
        }
    }
}
catch
{
    Console.WriteLine("Вы ввели некорректное значение");
} */





void Cube(int N)
{
    if (N<=0)
    {
        for (int n = N; n <= 1; n++)
        {
            Console.WriteLine($"{Math.Pow(n, 3)}");
        }
    }
    else
    {
        for (int n=1; n <= N; n++)
        {
            Console.WriteLine($"{Math.Pow(n, 3)}");
        }
    }
}
    try
{
    Console.WriteLine("Введите число");
    int N = Convert.ToInt32(Console.ReadLine());
    Cube(N);
}
catch
    {
        Console.WriteLine("Вы ввели некорректное значение");
    }
