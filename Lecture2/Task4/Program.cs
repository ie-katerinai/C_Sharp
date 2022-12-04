// See https://aka.ms/new-console-template for more information
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10); // положить в позицию массива (collection) с индексом (index) какое-то рандомное число из диапазона от 1 до 9!!!
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length; //определяем количество элементов
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int[] array = new int[10]; // создает новый массив в котоором будет 10 элементов, по умолчанию он будет наполнен нулями

FillArray(array); // метод, который заполняет массив
PrintArray(array); // метод, который распечатывает массив
