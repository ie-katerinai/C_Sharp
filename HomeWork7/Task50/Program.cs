// Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве,
// и возвращает позицию этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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

string SearchNumber(int[,] array, int numb)
{
    string result = "не существует";
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == numb)
            {
                result = "[" + i + "," + j + "]";
            }
        }
    }
    return result;
}

int[,] array = new int[3, 4];
FillArray(array);
PrintArray(array);
Console.WriteLine("Введите число для поиска");
int numb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Позиция искомого элемента в массиве: {SearchNumber(array, numb)}");
