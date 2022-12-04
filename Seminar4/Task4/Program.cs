﻿// Задача 30: Напишите программу, которая выводит
// массив из 8 элементов, заполненный нулями
// и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] rendr(int length) // функция создает массив
{
    int[] arr = new int[length]; // объявляем тип массива и даем ему имя = новый массив объявленного типа заданной размерности
    Random rnd = new Random(); // создает ячейку памяти (объект) с именем rnd типа Random
    for (int i = 0; i < length; i++) // перебирает все позиции массива
        {
            arr[i] = rnd.Next(0, 2); // генерирует целые числа от 0 до 1
        }
    return arr; // возвращает массив, так как тип функции int
}

int len = 8; // по условию задачи
int[] array = rendr(len); // вызываем функция, которая заполнила массив 0 и 1 и кладем ее результат в новый массив размером 8
Array.ForEach(array, Console.WriteLine); // вывод элементов массива на экран, заменяет цикл FOR
// for (int i = 0; i < len; i++)
// {
// Console.Write($"{array[i]} ");
// }
// Нельзя напечатать массив только с помощью Console.WriteLine(array), 
// нужно пройтись по каждому элементу и напечатать его. 
// Или использовать PrintArray