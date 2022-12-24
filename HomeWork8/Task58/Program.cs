// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j], 2}\t");
        Console.WriteLine();
    }
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(0, 10);
    }
}

void MatrixProduct(int[,] array1, int[,] array2, int [,] array3)
{
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            int mult = 0;
            for (int n = 0; n < array3.GetLength(1); n++)
            {
                array3[i, j] = mult + array1[i, n] * array2[n, j]; 
            }
        }
    }
    PrintArray(array3);
}


try
{
    Console.WriteLine("Введите количество строк первого двумерного массива");
    int rows1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов первого двумерного массива");
    int cols1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество строк второго двумерного массива");
    int rows2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов второго двумерного массива");
    int cols2 = Convert.ToInt32(Console.ReadLine());
    if (cols1 = rows2)
    {
        int[,] array1 = new int[rows1, cols1];
        FillArray(array1);
        PrintArray(array1);
        Console.WriteLine();
        int[,] array2 = new int[rows2, cols2];
        FillArray(array2);
        PrintArray(array2);
        Console.WriteLine();
        int[,] array3 = new int[rows1, cols2];
        MatrixProduct(array1, array2, array3);
        Console.WriteLine();
    }
    else Console.WriteLine("Матрицы перемножить нельзя");
}
catch (System.FormatException)
{
    Console.WriteLine("Некорректный ввод");
}