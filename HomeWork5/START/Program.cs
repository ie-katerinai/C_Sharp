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

try
{
    Console.WriteLine("Введите размерность массива");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] array = RendrArray(size);
    Console.WriteLine();
    PrintArray(array);

    int MinNumb = FindMin(array);
    Console.WriteLine();
    Console.WriteLine($"Минимальное число массива равно {MinNumb}");

    int IndMin = FindIndexMin(array);
    Console.WriteLine($"Индекс минимального числа массива равен {IndMin}");
    Console.WriteLine();

    int MaxNumb = FindMax(array);
    Console.WriteLine();
    Console.WriteLine($"Максимальное число массива равно {MaxNumb}");

    int IndMax = FindIndexMax(array);
    Console.WriteLine($"Индекс максимальноеминимального числа массива равен {IndMax}");
    Console.WriteLine();

    double meanSum = ArithmeticMean(array);
    Console.WriteLine($"Среднее арифметическое элементов массива равно {meanSum}");
    Console.WriteLine();
}
catch (System.FormatException) // ищет неверный формат ввоа
{
    Console.WriteLine("Вы ввели не число");
}
