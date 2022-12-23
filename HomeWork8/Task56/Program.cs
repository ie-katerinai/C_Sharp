// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


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

void SummRowsNum(int[,] array)
{ 
    int indexMin = 0; // индекс искомой строки
    int minSum = 0; // сумма строки
    int tempSumRow = 0;
    for (int j = 0; j < array.GetLength(1); j++)
            minSum += array[0, j];
    for (int i = 1; i < array.GetLength(0); i++)
    {
        for (int j = 0; array.GetLength(1); j++)
        {
            tempSumRow += array[i, j];
        }
        if (tempSumRow < minSum)
        {
            minSum = tempSumRow;
            indexMin = i;
        }
        tempSumRow = 0;
    }
    Console.WriteLine($"Номер строки с наименьшей суммой элементов: {indexMin} строка");
}
try
{
    Console.WriteLine("Введите количество строк двумерного массива");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов двумерного массива");
    int cols = Convert.ToInt32(Console.ReadLine());
    
    if (rows = cols)
    {
       Console.WriteLine("Вы задали не прямоугольный массив");
    }
    else
    {
        int[,] array = new int[rows, cols];
        FillArray(array);
        PrintArray(array);
        Console.WriteLine();
        SummRowsNum(array);
    }
}
catch (System.FormatException)
{
    Console.WriteLine("Некорректный ввод");
}