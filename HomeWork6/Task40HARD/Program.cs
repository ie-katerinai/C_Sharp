/*Задача 40 - HARD необязательная. На вход программы подаются три целых положительных числа.
Определить , является ли это сторонами треугольника.
Если да, то вывести всю информацию по нему - площадь, периметр, значения углов треугольника в градусах,
является ли он прямоугольным, равнобедренным, равносторонним.*/

void FillArray(int[] array) //заполняет массив
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}

void PrintArray(int[] array) // печатает массив
{
    foreach (int el in array)
        Console.Write($"{el} ");
    Console.WriteLine();
}

bool Check(int[] array) // проверяет, существует ли треугольник с такими сторонами
{
    bool result = false;
    if (
        array[0] < array[1] + array[2]
        && array[1] < array[0] + array[2]
        && array[2] < array[0] + array[1]
    )
        result = true;
    else
        result = false;
    return result;
}

void CheckTriangleCategory(int[] array) // равносторонний? равнобедренный? разносторонний?
{
    if (array[0] == array[1] && array[1] == array[2])
        Console.WriteLine("Треугольник равносторонний");
    else if (array[0] == array[1] || array[0] == array[2] || array[1] == array[2])
        Console.WriteLine("Треугольник равнобедренный");
    else
        Console.WriteLine("Треугольник разносторонний");
}

int[] ValueOfAngles(int[] array) // вычисление угллов
{
    int[] arr = new int[3];
    arr[0] = Convert.ToInt32(
        Math.Round(
            (
                Math.Acos(
                    (Math.Pow(array[0], 2) + Math.Pow(array[2], 2) - Math.Pow(array[1], 2))
                        / (2 * array[0] * array[2])
                )
                * 180
                / Math.PI
            ),
            2
        )
    );
    arr[1] = Convert.ToInt32(
        Math.Round(
            (
                Math.Acos(
                    (Math.Pow(array[0], 2) + Math.Pow(array[1], 2) - Math.Pow(array[2], 2))
                        / (2 * array[0] * array[1])
                )
                * 180
                / Math.PI
            ),
            2
        )
    );
    arr[2] = Convert.ToInt32(
        Math.Round(
            (
                Math.Acos(
                    (Math.Pow(array[1], 2) + Math.Pow(array[2], 2) - Math.Pow(array[0], 2))
                        / (2 * array[1] * array[2])
                )
                * 180
                / Math.PI
            ),
            2
        )
    );
    return arr;
}

void CheckRightTriangle(int[] array) // прямоугольный треугольник?
{
    if (array[0] == 90 || array[1] == 90 || array[2] == 90)
        Console.WriteLine("Треугольник прямоугольный");
}

int AreaOfTriangle(int[] array1, int[] array2) // вычисление площади
{
    int area = Convert.ToInt32(Math.Abs(((array1[0] * array1[1]) / 2) * Math.Sin(array2[0])));
    return area;
}

int PerimetrOfTriangle(int[] array) // вычисление периметра
{
    int perimetr = 0;
    for (int i = 0; i < array.Length; i++)
    {
        perimetr += array[i];
    }
    return perimetr;
}

try
{
    Console.WriteLine("Введите размеры строн треугольника");
    int[] array = new int[3];
    FillArray(array);
    Console.Write("Исходный массив: ");
    PrintArray(array);
    if (Check(array))
    {
        Console.WriteLine("Треугольник существует");
        CheckTriangleCategory(array);
        int[] angles = ValueOfAngles(array);
        Console.Write("Углы треугольника равны: ");
        PrintArray(angles);
        CheckRightTriangle(angles);
        Console.WriteLine($"Площадь треугольника равна {AreaOfTriangle(array, angles)}");
        Console.WriteLine($"Периметр треугольника равен {PerimetrOfTriangle(array)}");
    }
    else
        Console.WriteLine("Треугольник не существует");
}
catch (System.FormatException)
{
    Console.WriteLine("Некорректный ввод");
}
