// Задача 30: - HARD необязательная
// Напишите программу, которая выводит массив из 8 элементов,
// заполненный нулями и единицами в случайном порядке..
// Далее надо посчитать количество нулей и единиц, если единиц больше чем нулей
// то вывести TRUE на экран, иначе вывести False.

int[] RendrArray(int length) // функция создает массив
{
    int[] arr = new int[length]; // объявляем тип массива и даем ему имя = новый массив объявленного типа заданной размерности
    Random rnd = new Random(); // создает ячейку памяти (объект) с именем rnd типа Random
    for (int i = 0; i < length; i++) // перебирает все позиции массива
    {
        arr[i] = rnd.Next(0, 2); // генерирует целые числа от 0 до 1
    }
    return arr; // возвращает массив, так как тип функции int
}

int FindNumber(int[] array) // функция подсчета кол-ва 0 и 1
{
    int countNul = 0;
    int countOne = 0;
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == 0)
        {
            countNul++;
        }
        else
        {
            countOne++;
        }
        result = countOne - countNul; // результат бует отрицательное, 0 или положительное число
    }
    return result;
}

bool WhatIsMore(int result) // функция сравнения количества 0 и 1
{
    bool res = true;
    if (result > 0)
    {
        res = true;
    }
    else
    {
        res = false;
    }
    return res;
}
try
{
    int len = 8; // по условию задачи
    int[] array = RendrArray(len); // вызываем функция, которая заполнила массив 0 и 1 и кладем ее результат в новый массив размером 8
    Array.ForEach(array, Console.WriteLine); // вывод элементов массива на экран, заменяет цикл FOR
    int resultFindNumber = FindNumber(array); // вызов функции подсчета 0 и 1
    Console.WriteLine(WhatIsMore(resultFindNumber)); // вызов функции сравнения количества
}
catch (System.Exception)
{
    Console.WriteLine("Введена некорректная строка");
}
