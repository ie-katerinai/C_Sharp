// Задача 22. Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу квадратов чисел 
// от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.WriteLine("Введите число");
int N=Convert.ToInt32(Console.ReadLine());
if (N<0)
{
    for (int n=N; n<=1; n++)
    {
        int num =(n*n);
        Console.WriteLine($"Квадораты чисел: {num}");
    }

}
for (int n=1; n<=N; n++)
{
    int num =(n*n);
    Console.WriteLine($"Квадораты чисел: {num}");
}
