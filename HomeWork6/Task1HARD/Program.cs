// Задача 1 HARD необязательная.
// Сгенерировать массив случайных целых чисел размерностью m*n (размерность вводим с клавиатуры).
// Вывести на экран красивенько таблицей. Найти минимальное число и его индекс,
// найти максимальное число и его индекс. Вывести эту информацию на экран.

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(0, 50);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j], 1}\t");
        Console.WriteLine();
    }
}

void FindMax(int[,] array) // функция поиска индекса максимального элемента массива
{
    int max = array[0, 0];
    int indexIMax = 0;
    int indexJMax = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            if (array[i, j] > max)
            {
                max = array[i, j];
                indexIMax = i;
                indexJMax = j;
            }
    }
    Console.WriteLine($"Максимальный элемент равен {max}, его индекс:({indexIMax},{indexJMax})");
}

void FindMin(int[,] array) // функция поиска индекса минимального элемента массива
{
    int min = array[0, 0];
    int indexIMin = 0;
    int indexJMin = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            if (array[i, j] < min)
            {
                min = array[i, j];
                indexIMin = i;
                indexJMin = j;
            }
    }
    Console.WriteLine($"Минимальный элемент равен {min}, его индекс:({indexIMin},{indexJMin})");
}
try
{
    Console.WriteLine("Введите количество строк двумерного массива");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов двумерного массива");
    int n = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[m, n];
    FillArray(array);
    PrintArray(array);
    Console.WriteLine();
    FindMin(array);
    FindMax(array);
}
catch (System.FormatException)
{
    Console.WriteLine("Некорректный ввод");
}
