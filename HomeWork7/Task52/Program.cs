// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(0, 21);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j], 3}\t");
        Console.WriteLine();
    }
}

void CalcAverageSum(int[,] array)
{
    double sum = 0.0;
    double result = 0.0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum = sum + Convert.ToDouble(array[i, j]);
        }
        result = Math.Round((sum / array.GetLength(0)), 1);
        Console.Write($"{result, 3}\t" + " ");
        sum = 0.0;
    }
}

double[] CalcAvgSumArray(int[,] array)
{
    double sum = 0.0;
    double[] result = new double[4];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum = sum + Convert.ToDouble(array[i, j]);
            result[i] = Math.Round((sum / array.GetLength(0)), 1);
        }
        
        sum = 0.0;
    }
    return result;
}

int[,] array = new int[3, 4];
FillArray(array);
PrintArray(array);
Console.WriteLine("Среднее арифметическое каждого столбца:");
CalcAverageSum(array);
Console.WriteLine();
double[] mass = CalcAvgSumArray(array);
Console.WriteLine(mass);