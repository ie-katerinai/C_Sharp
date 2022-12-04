// Функция заполняет массив 

void FillArray(int[] collection) // тип_данных ИмяМетода(тип_данных имя_аргумента)
{
    int length = collection.Length; // получает длину массива
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10); // кладет случайное число из диапазона от 1 до 9 в ячейку index
        index++;
    }
}

FillArray(имя массива); // вызов функции