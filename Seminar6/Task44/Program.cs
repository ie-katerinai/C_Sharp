// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи 0 и 1.
/*Console.WriteLine("Введите, какое количество чисел Фибоначчи вывести на экран");
int N = Convert.ToInt32(Console.ReadLine());
int num1 = 0;
int num2 = 1;
int count = 0;
Console.Write($"0, ");
for (int i = 2; i <= N; i++)

{
    count = num1 + num2;
    num2 = num1;
    num1 = count;
    Console.Write($"{count}, ");
}


*/

void PrintArray(int[] mass) // фунция вывода массива на экран
{
    foreach (int el in mass)
    {
        Console.Write(el + " ");
    }
    Console.WriteLine();
}

int[] Fibonacci(int size)
{
    int[] mass = new int[size];
    for (int i = 0; i < size; i++)
    {
        if (i == 0)
            mass[i] = 0;
        else if (i == 1)
            mass[i] = 1;
        else
            mass[i] = mass[i - 2] + mass[i - 1];
    }
    return mass;
}

Console.WriteLine("Введите, какое количество чисел Фибоначчи вывести на экран");
int num = Convert.ToInt32(Console.ReadLine());
int[] newArray = Fibonacci(num);
PrintArray(newArray);