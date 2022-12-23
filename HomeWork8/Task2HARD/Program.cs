// Задача 2 HARD необязательная. Считается за четыре обязательных ) то есть три этих и одна с будущего семинара
// Сгенерировать массив случайных целых чисел размерностью m*n (размерность вводим с клавиатуры) ,
// причем чтоб количество элементов было четное. Вывести на экран красивенько таблицей.

// Перемешать случайным образом элементы массива, причем чтобы каждый элемент гарантированно и
// только один раз переместился на другое место и выполнить перемешивание за m*n / 2 итераций.
// То есть если массив три на четыре, то надо выполнить за 6 итераций.
// И далее в конце опять вывести на экран как таблицу.

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

void GenRandomIndex(int[,] arrayIndex, int rows, int cols)
{
    arrayIndex[0, 0] = 0;
    arrayIndex[1, 0] = 0;
    arrayIndex[0, 1] = 0;
    arrayIndex[1, 1] = 0;
    while ((arrayIndex[0, 0] == arrayIndex[1, 0]) && (arrayIndex[0, 1] == arrayIndex[1, 1]))
    {
        arrayIndex[0, 0] = new Random().Next(0, rows);
        arrayIndex[1, 0] = new Random().Next(0, rows);
        arrayIndex[0, 1] = new Random().Next(0, cols);
        arrayIndex[1, 1] = new Random().Next(0, cols);
    }
}

// void CheckStatus(int[,] massZero, int[,] arrayIndex)
// {
//     while ((massZero[i1, j1] == 1) && (massZero[i2, j2] == 1))
//         //GenRandomIndex()
// }

void ChangeArrayElements(int[,] arrayIndex, int[,] massZero, int[,] arrayNumbs)
{
    //int count = 0;

    // while (count <= arrayNumbs.GetLength(0) * arrayNumbs.GetLength(1))
    //     if ((massZero[i1, j1] != 1) && (massZero[i2, j2] != 1))
    //     {
    int i1 = arrayIndex[0, 0];
    int j1 = arrayIndex[0, 1];
    int i2 = arrayIndex[1, 0];
    int j2 = arrayIndex[1, 1];
    int buf = arrayNumbs[i1, j1];
    arrayNumbs[i1, j1] = arrayNumbs[i2, j2];
    arrayNumbs[i2, j2] = buf;
    massZero[i1, j1] = 1;
    massZero[i2, j2] = 1;
    //count = count + 2;
    // }
    // else
    //     GeniretIndex(arrayIndex, arrayNumbs.GetLength(0), arrayNumbs.GetLength(1));
}

Console.WriteLine("Введите количество строк двумерного массива");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов двумерного массива");
int cols = Convert.ToInt32(Console.ReadLine());
if (rows % 2 == 0 || cols % 2 == 0)
{
    int[,] array = new int[rows, cols];
    FillArray(array);
    Console.WriteLine("Исходный массив:");
    PrintArray(array);

    int[,] arrayZerro = new int[rows, cols];
    Console.WriteLine("Нулевой массив:");
    PrintArray(arrayZerro);
    int[,] arrayIndex = new int[2, 2];
    int[,] finArray = new int[rows, cols];
    int count = 0;
    while (count <= array.GetLength(0) * array.GetLength(1))
    {
        //Console.WriteLine("Массив индексов:");
        GenRandomIndex(arrayIndex, rows, cols);
        //PrintArray(arrayIndex);


        //Console.WriteLine("Конечный массив:");
        ChangeArrayElements( 
            arrayIndex,
            arrayZerro,
            array
        );
        //PrintArray(finArray);
        count = count + 2;
    }

    //Console.WriteLine("Нулевой массив:");
    //FillZerroArray(array);
    PrintArray(array);
}
else
    Console.WriteLine("Количество элементов в массиве нечетное.");
