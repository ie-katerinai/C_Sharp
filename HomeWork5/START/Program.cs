// Задача HARD STAT необязательная: Задайте массив случайных целых чисел.
// Найдите максимальный элемент и его индекс,
// минимальный элемент и его индекс,
// среднее арифметическое всех элементов.
// Сохранить эту инфу в отдельный массив и вывести на экран с пояснениями.
// Найти медианное значение первоначалального массива , возможно придется кое-что для этого дополнительно выполнить.

int[] RendrArray(int size) // функция создания массива из случайных целых чисел
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(1, 100);
    return array;
}

void PrintArray(int[] array) // функция печати созданного массива
{
    foreach (int el in array)
        Console.Write($"{el} ");
    Console.WriteLine();
}

void PrintStringArray(string[] array) // функция печати созданного массива
{
    foreach (string el in array)
        Console.WriteLine($"{el} ");
    Console.WriteLine();
}

int FindMin(int[] array) // функция нахождения максимального элемента массива
{
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
        if (array[i] < min)
            min = array[i];
    return min;
}

int FindMax(int[] array) // функция нахождения максимального элемента массива
{
    int max = array[0];
    for (int i = 0; i < array.Length; i++)
        if (array[i] > max)
            max = array[i];
    return max;
}

int FindIndexMax(int[] array) // функция поиска индекса максимального элемента массива
{
    int max = array[0];
    int indexMax = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] > max)
        {
            max = array[i];
            indexMax = i;
        }
    return indexMax;
}

int FindIndexMin(int[] array) // функция поиска индекса минимального элемента массива
{
    int min = array[0];
    int indexMin = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] < min)
        {
            min = array[i];
            indexMin = i;
        }
    return indexMin;
}

double ArithmeticMean(int[] array) // функция подсчета среднего арифметического
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
        sum += array[i];
    double arMean = sum / array.Length;
    return arMean;
}

void SortingArray(int[] array) // функция сортировки массива от min до max
{
    int len = array.Length;
    for (int i = 0; i < len; i++)
    {
        for (int j = 0; j < len - 1; j++)
        {
            if(array[j] > array[j + 1])
            {
                int max = array[j + 1];
                array[j + 1] = array [j];
                array[j] = max;
            }
        }
    }
}

int MedianValue(int[] array) // функция нахождения медианы
{
    int value = 0;
    if (array.Length % 2 == 0)
    {
        value = (array[array.Length / 2] + array[array.Length / 2 - 1]) / 2;
    }
    else
    {
        value = array[array.Length / 2];
    }
    return value;
}

try
{
    Console.WriteLine("Введите размерность массива");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] array = RendrArray(size);
    Console.WriteLine();
    PrintArray(array);
    Console.WriteLine();

    string[] stringArray = new string[5];
    stringArray[0] = "Минимальное число массива равно " + FindMin(array);
    stringArray[1] = "Индекс минимального числа массива равен " + FindIndexMin(array);
    stringArray[2] = "Максимальное число массива равно " + FindMax(array);
    stringArray[3] = "Индекс максимального числа массива равен " + FindIndexMax(array);
    stringArray[4] = "Среднее арифметическое элементов массива равно " + ArithmeticMean(array);


    PrintStringArray(stringArray);

    Console.WriteLine();

    SortingArray(array);
    PrintArray(array);
    Console.WriteLine($"Медианное значение массива равно {MedianValue(array)}");

}
catch (System.FormatException) // ищет неверный формат ввоа
{
    Console.WriteLine("Вы ввели не число");
}
