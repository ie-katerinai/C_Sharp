
//Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
//N = 5 -> "1, 2, 3, 4, 5"
//N = 6 -> "1, 2, 3, 4, 5, 6"

Console.WriteLine("Введите целое число");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($" {PrintNum(N)}");
Console.WriteLine($" {PrintNumRec(N)}");

string PrintNum(int N)
{
    string res = "";
    while (true)
    {
        res = Convert.ToString(N) + ", " + res;
        N--;
        if (N == 0)
            break;
    }
    return res;
}

string PrintNumRec(int N)
{
    if (N == 0) return "";
    return PrintNumRec(N - 1) + ", " + Convert.ToString(N);
}