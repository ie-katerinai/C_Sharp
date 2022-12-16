/* Задача 2 VERY HARD необязательная
Имеется список чисел. Создайте список, в который попадают числа, описывающие максимальную возрастающую последовательность.
Порядок элементов менять нельзя. Одно число - это не последовательность.
Пример:
[1, 5, 2, 3, 4, 6, 1, 7] => [1, 7]
[1, 5, 2, 3, 4, 1, 7, 8 , 15 , 1 ] => [1, 5]
[1, 5, 3, 4, 1, 7, 8 , 15 , 1 ] => [3, 5]*/

int[] FillArray(int size) // функция создания массива из случайных целых чисел
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(1, 10);
    return array;
}

int[] CheckUniqArray(int[] array) // функция проверки на уникальность элементов
{
    for (int i = 0; i < array.Length - 1; i++)
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[i] == array[j])
            {
                array[j] = new Random().Next(1, 11);
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

int FindMin(int[] array) // функция нахождения минимальный элемента массива
{
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
        if (array[i] < min)
            min = array[i];
    return min;
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

string FindLength(int[] array, int numMin) // функция поиска длины последовательности
{
    int[] massCount = new int[array.Length];
    string[] massNumbs = new string[array.Length];
    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        int count = 0;
        string str = "";
        for (int j = 0; j < array.Length; j++)
        {
            if (numMin == array[j])
            {
                count++;
                str = str + array[j] + " ";
                massNumbs[i] = str;
                numMin++;
                j = -1;
            }
            massCount[i] = count;
        }
        numMin++;
    }
    index = FindIndexMax(massCount);
    return massNumbs[index];
}

int size = new Random().Next(1, 10);
int[] array = FillArray(size);
Console.WriteLine("Исходный массив:");
PrintArray(array);
Console.WriteLine();
CheckUniqArray(array);
Console.WriteLine("Массив с уникальными элементами:");
PrintArray(array);
Console.WriteLine();
int min = FindMin(array);

Console.WriteLine("Максимальная возрастающая последовательность:");
Console.WriteLine(FindLength(array, min));
