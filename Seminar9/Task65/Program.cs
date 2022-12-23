// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

Console.Write("Введите целое число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое число N: ");
int N = Convert.ToInt32(Console.ReadLine());


Console.WriteLine($"M={M}; N={N} -> {Posled(N,M)}");

string Posled(int N, int M)
{
    if (N == M) return Convert.ToString(M);
    else return Posled(N - 1, M) + ", " + Convert.ToString(N);
}
