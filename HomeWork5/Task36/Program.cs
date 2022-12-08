// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] RendrArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(1, 1000);
    return array;
}

void PrintArray(int[] array)
{
    foreach (int el in array)
        Console.Write($"{el} ");
    Console.WriteLine();
}

int SumOfEvenElements(int[] array)
{
    int sum = 0;
    for (int i = 2; i < array.Length; i = i + 2)
            sum += array[i];
    return sum;
}

try
{
Console.WriteLine("Введите размерность массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = RendrArray(size);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Сумма элементов массива, стоящих на четных позициях, равна {SumOfEvenElements(array)}");
}
catch (System.FormatException) // ищет неверный формат ввоа
{
    Console.WriteLine("Вы ввели не число");
}