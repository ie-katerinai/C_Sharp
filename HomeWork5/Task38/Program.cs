// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

double[] RendrArray(int size)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
        array[i] = Math.Round(new Random().NextDouble() * 100, 4);
    return array;
}

void PrintArray(double[] array)
{
    foreach (double el in array)
        Console.Write($"{el} ");
    Console.WriteLine();
}

double FindMin(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
        if (array[i] < min)
            min = array[i];
    return min;
}

double FindMax(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
        if (array[i] > max)
            max = array[i];
    return max;
}

double DifMaxAndMin(double MaxNumb, double MinNumb)
{
    double dif = MaxNumb - MinNumb;
    return dif;
}

try
{
    Console.WriteLine("Введите размерность массива");
    int size = Convert.ToInt32(Console.ReadLine());
    double[] array = RendrArray(size);
    Console.WriteLine();
    PrintArray(array);
    double MinNumb = FindMin(array);
    Console.WriteLine();
    Console.WriteLine($"Минимальное число массива равно {MinNumb}");
    double MaxNumb = FindMax(array);
    Console.WriteLine();
    Console.WriteLine($"Максимальное число массива равно {MaxNumb}");
    Console.WriteLine();
    Console.WriteLine($"Разница между максимальным и минимальным элементом массива равна {DifMaxAndMin(MaxNumb, MinNumb)}");
}
catch (System.FormatException) // ищет неверный формат ввоа
{
    Console.WriteLine("Вы ввели не число");
}
