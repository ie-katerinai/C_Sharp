// Задача 29: Напишите программу, которая задаёт массив из 8
// элементов с клавиатуры и выводит массив на экран.

int[] rendr(string arr) // функция создает массив
{
    int[] arr = new int[8]; // объявляем тип массива и даем ему имя, размерность
    {
        int i = 0;
        string[] arrays = arr.Split(' ');
        foreach (var arr in arrays)
        {
            arr[i] = Convert.ToInt32(arrays[i]);
            i++;
        }
    }
    return arr; // возвращает массив, так как тип функции int
}

array[] numb = s.Split(' ');

foreach (var num in numbs)
{
    Console.WriteLine($"Substring: {sub}");
}
