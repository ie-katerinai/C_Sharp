// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи 0 и 1.
Console.WriteLine("Введите, какое количество чисел Фибоначчи вывести на экран");
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


/*

void PrintArray(int[] array) // фунция вывода массива на экран
{
    int count = array.Length;

    for (int i=0; i < count; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}

void Fibonacci(int[] mass, int size)
{
    mass[0] = 0;
    mass[1] = 1;
    for (int i = 2; i < size; i++)
        mass[i] = mass[i - 2] + mass[i - 1];
}

Console.WriteLine("Введите, какое количество чисел Фибоначчи вывести на экран");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = new int[num];
//FillArray(array);

Console.WriteLine($"{Fibonacci(array, num)}");
PrintArray(array);*/
