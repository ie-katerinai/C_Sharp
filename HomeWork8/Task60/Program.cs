﻿// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся
// (HARD - случайных уникальных) двузначных чисел. Напишите программу,
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i}, {j}, {k})");
                Console.WriteLine();
            }
        }
    }
}

void FillArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = new Random().Next(10, 100);
            }
        }
    }
}

// void CheckUniqArray(int[,,] array) // функция проверки на уникальность элементов
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 if (array[i, j, k] == array[i+1, j+1, k+1])
//                 {
//                     array[i+1, j+1, k+1] = new Random().Next(10, 100);
//                     i = 0;
//                     j = i + 1;
//                 }
//          }
//         }
//     }
// }
try
{
    Console.WriteLine("Введите количество строк трехмерного массива");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов трехмерного массива");
    int cols = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество рядов трехмерного массива");
    int layers = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    int[,,] array = new int[rows, cols, layers];
    FillArray(array);
    PrintArray(array);
    Console.WriteLine();
}
catch (System.FormatException)
{
    Console.WriteLine("Некорректный ввод");
}
