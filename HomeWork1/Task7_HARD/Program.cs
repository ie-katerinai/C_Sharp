// Напишите программу, которая принимает на вход целое число любой разрядности и 
// на выходе показывает третью цифру слева этого числа или говорит, что такой цифры нет. Через строку решать нельзя.
Console.WriteLine("Введите целое число");
int N = Convert.ToInt32(Console.ReadLine());
if (N < 0)
{
    N = -N;
}
if (Math.Log10(N) + 1 < 3)
{
    Console.WriteLine("Третья цифра в числе отсутствует");
}
else 
{
    while (Math.Log10(N) + 1 > 4)
    {
        N = N / 10;
    }
    Console.WriteLine($"Третья цифра числа: {N % 10}");
}