// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Требуется ввести число");
int N = Convert.ToInt32(Console.ReadLine());
if (N > -2 && N < 2)
{
    Console.WriteLine($"Нет четных чисел в диапазоне от 1 до {N}");
}
else  if (N > 0)
    {
        int i = 2;
        while (i <= N)
        {
            Console.WriteLine(i);
            i=i+2;
        }
    }
    else 
    {
        int rem = N % 2;
        if (rem == 0)
        { 
            while (N < 0)
            {
                Console.WriteLine(N);
                N = N + 2;
            }
        }
        else 
        {
            N= N + 1;
            while (N < 0)
            {
                Console.WriteLine(N);
                N = N + 2;
            }
        }
    }