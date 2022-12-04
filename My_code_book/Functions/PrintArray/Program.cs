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