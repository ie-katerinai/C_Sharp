// Задача 30: - HARD необязательная
// Напишите программу, которая на вход получает размерность массива.
// Далее заполняет его случайными уникальными числами и выводит на экран.
// Далее производим сортировку массива от большего к меньшему и выводим на экран.
// Далее придумываем алгоритм перемешивания списка на основе случайности ,
// применяем этот алгоритм и выводим на экран результат.
// Встроенные методы работы со списками использовать нельзя.

int[] RendrArray(int size) // функция создания массива из случайных целых чисел
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(1, 100);
    return array;
}

int[] CheckUniqArray(int[] array) // функция проверки на уникальность элементов
{
    for (int i = 0; i < array.Length - 1; i++)
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[i] == array[j])
            {
                array[j] = new Random().Next(1, 100);
                i = 0;
                j = i + 1;
            }
        }
    return array;
}

void PrintArray(int[] array) // функция печати созданного массива
{
    foreach (int el in array)
        Console.Write($"{el} ");
    Console.WriteLine();
}

void SortingArray(int[] array) // функция сортировки массива от max до min
{
    int len = array.Length;
    for (int i = 0; i < len; i++)
    {
        for (int j = 0; j < len - 1; j++)
        {
            if (array[j] < array[j + 1])
            {
                int max = array[j + 1];
                array[j + 1] = array[j];
                array[j] = max;
            }
        }
    }
}

void MixingIndexArray(int[] array) // функция перемешивания элементов
{
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < array.Length - 1; j++)
        {
            j = new Random().Next(0, array.Length);
            int num = array[i];
            array[i] = array[j];
            array[j] = num;
        }
    }
}

try
{
    Console.WriteLine("Введите размерность массива");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] array = RendrArray(size);
    Console.WriteLine("Исходный массив:");
    PrintArray(array);
    Console.WriteLine();
    CheckUniqArray(array);
    Console.WriteLine("Массив с уникальными элементами:");
    PrintArray(array);
    Console.WriteLine();
    SortingArray(array);
    Console.WriteLine("Отсортированный массив от большего к меньшему элементу:");
    PrintArray(array);
    Console.WriteLine();
    Console.WriteLine("Перемешанный массив случайным образом:");
    MixingIndexArray(array);
    PrintArray(array);
}
catch (System.FormatException) // ищет неверный формат ввоа
{
    Console.WriteLine("Вы ввели не число");
}
