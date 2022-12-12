// Задача 1 HARD необязательная. 
// Сгенерировать массив случайных целых чисел размерностью m*n (размерность вводим с клавиатуры). 
// Вывести на экран красивенько таблицей. Найти минимальное число и его индекс, 
// найти максимальное число и его индекс. Вывести эту информацию на экран.

void FillArray(int[,] array)
{
    for (int i=0;i<array.GetLength(0);i++)
       for (int j=0;j<array.GetLength(1);j++) 
            array[i,j] = new Random().Next(0,100);
}

void PrintArray(int[,] array)
{
    for (int i=0;i<array.GetLength(0);i++)
       {
        for (int j=0;j<array.GetLength(1);j++) 
            Console.Write($"{array[i,j],3}\t");
        Console.WriteLine();
       }
}

void PrintStringArray(string[] array) // функция печати созданного массива
{
    foreach (string el in array)
        Console.WriteLine($"{el} ");
    Console.WriteLine();
}

int FindMin(int[,] array) // функция нахождения максимального элемента массива
{
    int min = array[0,0];
    for (int i=0;i<array.GetLength(0);i++)
       {
        for (int j=0;j<array.GetLength(1);j++)
            if (array[i, j] < min)
            min = array[i, j];
       }
    return min;
}

int FindMax(int[,] array) // функция нахождения максимального элемента массива
{
    int max = array[0, 0];
    for (int i=0;i<array.GetLength(0);i++)
       {
        for (int j=0;j<array.GetLength(1);j++)
            if (array[i, j] > max)
            max = array[i, j];
       }
    return max;
}

void FindIndexMax(int[,] array) // функция поиска индекса максимального элемента массива
{
    int max = array[0,0];
    int indexIMax = 0;
    int indexJMax = 0;
    for (int i=0;i<array.GetLength(0);i++)
       {
        for (int j=0;j<array.GetLength(1);j++)
        if (array[i,j] > max)
        {
            max = array[i,j];
            indexIMax = i;
            indexJMax = j;
        }
       }
    Console.Write($"{indexIMax}, {indexJMax}");
}

void FindIndexMin(int[,] array) // функция поиска индекса минимального элемента массива
{
    int min = array[0,0];
    int indexIMin = 0;
    int indexJMin = 0;
    for (int i=0;i<array.GetLength(0);i++)
       {
        for (int j=0;j<array.GetLength(1);j++)
        if (array[i, j] < min)
        {
            min = array[i, j];
            indexIMin = i;
            indexJMin = j;
        }
       }
    Console.Write($"{indexIMin}, {indexJMin}");
}



Console.WriteLine("Введите количество строк двумерного массива");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов двумерного массива");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int [m,n];
FillArray(array);
PrintArray(array);

string[] stringArray = new string[4];
    stringArray[0] = "Минимальное число массива равно " + FindMin(array);
    stringArray[1] = "Индекс минимального числа массива равен " + FindIndexMin(array);
    stringArray[2] = "Максимальное число массива равно " + FindMax(array);
    stringArray[3] = "Индекс максимального числа массива равен " + FindIndexMax(array);

PrintStringArray(stringArray);