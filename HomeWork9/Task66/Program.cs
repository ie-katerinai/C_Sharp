// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumRec(int M, int N)
{
    if (M > N)
    {
        if (M < N)
            return 0;
        return M + SumRec(M - 1, N);
    }
    if (M < N)
    {
        if (M > N)
            return 0;
        return N + SumRec(M, N - 1);
    }
    else
        return M;
}

try
{
    Console.WriteLine("Введите первое целое число");
    int M = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе целое число");
    int N = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Сумма чисел в заданном интервале равна {SumRec(M, N)}");
}
catch (System.FormatException)
{
    Console.WriteLine("Некорректный ввод");
}
