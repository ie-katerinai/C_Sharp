// Задача 29: Напишите программу, которая задаёт массив из 8
// элементов с клавиатуры и выводит массив на экран.

void Rendr(string text)
{
    string[] stringArray = text.Split(' ');

    if (stringArray.Length == 8)
    {
        int[] intArray = new int[stringArray.Length];
        int i = 0;
        foreach (var sub in stringArray)
        {
            intArray[i] = Convert.ToInt32(sub);

            Console.WriteLine(intArray[i]);
            i++;
        }
    }
    else
    {
        Console.WriteLine("Вы ввели массив не из 8 элементов");
    }
}
try
{
    Console.WriteLine("Ввеите массив из 8 элементов через пробел");
    string a = Console.ReadLine();
    Rendr(a);
}
catch (System.Exception)
{
    Console.WriteLine("Введена некорректная строка");
}


















// int[] rendr(string arr) // функция создает массив
// {
//     int[] arr = new int[8]; // объявляем тип массива и даем ему имя, размерность
//     {
//         int i = 0;
//         string[] arrays = arr.Split(' ');
//         foreach (var arr in arrays)
//         {
//             arr[i] = Convert.ToInt32(arrays[i]);
//             i++;
//         }
//     }
//     return arr; // возвращает массив, так как тип функции int
// }

// array[] numb = s.Split(' ');

// foreach (var num in numbs)
// {
//     Console.WriteLine($"Substring: {sub}");
// }
