// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] Rendr(string text)
{
    string[] stringArray = text.Split(' ');
    int[] intArray = new int[stringArray.Length];
    int i = 0;
    foreach (var sub in stringArray)
    {
        intArray[i] = Convert.ToInt32(sub);
        i++;
    }
    return intArray;
}

int PositiveNumbers(int[] array)
{
    int count = 0;
    foreach (int el in array)
    {
        if (el > 0)
            count++;
    }
    return count;
}

try
{
    Console.WriteLine("Введите числа через пробел");
    int[] array = Rendr(Console.ReadLine());
    Console.WriteLine();
    Console.WriteLine($"Количество положительных элементов массива равно {PositiveNumbers(array)}");
    Console.WriteLine();
}
catch (System.FormatException)
{
    Console.WriteLine("Некорректный ввод");
}
