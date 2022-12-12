// Задача 40: Напишите программу, которая принимает на
// вход три числа и проверяет, может ли существовать
// треугольник с сторонами такой длины.

void CreateArray(int[] mass) //заполняет массив
{

    for (int index = 0; index < mass.Length; index++)
    {
        mass[index] = Convert.ToInt32(Console.ReadLine());
    }

}

void PrintArray(int[] mass)
{
    foreach (int el in mass)
        Console.Write($"{el} ");
    Console.WriteLine();
}

void Check(int[] mass)
{
    int index = 0;
    int sum = mass[index+1] + mass[index+2];
    if(mass[index] < sum)  Console.WriteLine("Существует");
    else Console.WriteLine("Не существует");
}

Console.WriteLine("Введите размеры строно треугольника");
int[] array = new int[3];
CreateArray(array);
PrintArray(array);
Check(array);