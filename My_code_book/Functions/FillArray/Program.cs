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





void FillArray(int[] array) //заполняет массив
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}


void FillArray(int[,] array) // создание двумерного массива целых чисел
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(0, 50);
}