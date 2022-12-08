// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

double[] RendrArray(int size)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next();
    return array;
}

void PrintArray(double[] array)
{
    foreach (int el in array)
        Console.Write($"{el} ");
    Console.WriteLine();
}

// int SumOfEvenElements(int[] array)
// {
//     int sum = 0;
//     for (int i = 2; i < array.Length; i = i + 2)
//             sum += array[i];
//     return sum;
// }

Console.WriteLine("Введите размерность массива");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = RendrArray(size);
Console.WriteLine();
PrintArray(array);
// Console.WriteLine();
// Console.WriteLine($"Сумма элементов массива, стоящих на четных позициях, равна {SumOfEvenElements(array)}");