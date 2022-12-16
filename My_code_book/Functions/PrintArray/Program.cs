// Функция печати массива

void PrintArray(int[] col) // тип_данных ИмяМетода(тип_данных имя_аргумента)
{
    int count = col.Length; // количество элементов
    int position = 0;       // номер позиции элементов
    while (position < count)
    {
        Console.WriteLine(col[position]); // выводит на экран значение текущего элемента, пока не напечатает весь массив
        position++;
    }
}
PrintArray(имя массива); // вызов функции



void PrintArray(int[] array) // функция печати созданного массива
{
    foreach (int el in array)
        Console.Write($"{el} ");
    Console.WriteLine();
}




void PrintArray(int[,] array) // генирация целых чисел для двумерного массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j], 1}\t");
        Console.WriteLine();
    }
}