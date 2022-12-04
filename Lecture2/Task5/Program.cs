// Найти позицию нужного элемента в массиве с использованием метода
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

int IndexOf(int[] collection, int find)
{
int count = collection.Length;
int index = 0;
int position = -1; // если элемента не найдется в массиве, то нам вернуть значение -1
while (index < count)
{
    if (collection[index] == find)
    {
        position = index; // нашли первое вхождение
        break;
    }
    index++;
}
return position;
}

int[] array = new int[10]; // создает новый массив в котоором будет 10 элементов, по умолчанию он будет наполнен нулями

FillArray(array); // метод, который заполняет массив
array[4] = 4; //искуственно, принудительно вводим числа на позиции 
array[6] = 4; // на равне со случайным подбором

PrintArray(array); // метод, который распечатывает массив
Console.WriteLine();

int pos = IndexOf(array, 765);
Console.WriteLine(pos);
