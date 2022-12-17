// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// void PrintArray(int[,] array)
// {
//     for (int i=0;i<array.GetLength(0);i++)
//        {
//         for (int j=0;j<array.GetLength(1);j++)
//             Console.Write($"{array[i,j],3}\t");
//         Console.WriteLine();
//        }
// }

double[,] RendrArray(int[,] size)
{
    double[,] array = new double[size];
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = Math.Round(new Random().NextDouble() * 100, 1);
    return array;
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(-20, 21);
}

Console.WriteLine("Введите количество строк двумерного массива");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов двумерного массива");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, cols];
FillArray(array);
RendrArray(array);
