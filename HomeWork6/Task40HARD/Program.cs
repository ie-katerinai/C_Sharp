/*Задача 40 - HARD необязательная. На вход программы подаются три целых положительных числа. 
Определить , является ли это сторонами треугольника. 
Если да, то вывести всю информацию по нему - площадь, периметр, значения углов треугольника в градусах, 
является ли он прямоугольным, равнобедренным, равносторонним.*/

void FillArray(int[] mass) //заполняет массив
{

    for (int i = 0; i < mass.Length; i++)
    {
        mass[i] = Convert.ToInt32(Console.ReadLine());
    }
}

void PrintArray(int[] mass) // печатает массив
{
    foreach (int el in mass)
        Console.Write($"{el} ");
    Console.WriteLine();
}

void Check(int[] mass) // проверяет, существует ли треугольник с такими сторонами
{
    int i = 0;
    int sum = mass[i + 1] + mass[i + 2];
    if(mass[i] < sum)  Console.WriteLine("Существует");
    else Console.WriteLine("Не существует");
}

void CheckTriangleCategory(int[] mass) // равносторонний? равнобедренный? разносторонний?
{
    if(mass[0] == mass[1] && mass[1] == mass[2] ) Console.WriteLine ("равносторонний");
    else if (mass[0] == mass[1] || mass[0] == mass[2] || mass[1] == mass[2]) Console.WriteLine("равнобедренный");
    else Console.WriteLine("разносторонний");
}

// double[] ValueOfAngles(int[] mass) // вычисление угллов
// {
//     double[] arr = new double[3];
//     arr[0] = Math.Round((Math.Acos((Math.Pow(mass[0],2) + Math.Pow(mass[2],2) - Math.Pow(mass[1],2)) / (2 * mass[0] * mass[2])) * 180/ Math.PI),2);
//     arr[1] = Math.Round((Math.Acos((Math.Pow(mass[0],2) + Math.Pow(mass[1],2) - Math.Pow(mass[2],2)) / 2 * mass[0] * mass[1]) * 180/ Math.PI),2);
//     arr[2] = Math.Round((Math.Acos((Math.Pow(mass[1],2) + Math.Pow(mass[2],2) - Math.Pow(mass[0],2)) / 2 * mass[1] * mass[2]) * 180/ Math.PI),2);
//     return arr;
// }

void CheckRightTriangle (double[] mass) // прямоугольный треугольник?
{
    if (mass[0] == 90 || mass[1] == 90 || mass[2] == 90)
    Console.WriteLine("прямоуголный ");
}

double AreaOfTriangle(int[] mass1, int[] mass2) // вычисление площади
{
    double area = ((mass1[0] * mass1[1]) / 2) * Math.Sin(mass2[0]);
    return area;
}

int PerimetrOfTriangle(int[] mass) // вычисление периметра
{
    int perimetr = 0;
    for(int i = 0; i < mass.Length; i++)
    {
        perimetr +=  mass[i];
    }
    return perimetr;
}
void FillDoubleArray(int[] mass, int[]array)
{
    int length = mass.Length;
    for (int i = 0; i < length; i++)
    {
        mass[i]=new ValueOfAngles(array);
    }

}

Console.WriteLine("Введите размеры строн треугольника");
int[] array = new int[3];
FillArray(array);
PrintArray(array);
Check(array);
//double[] angles = new double[3];


double[] anglesArray = new double[3];
    arr[0] = Math.Round((Math.Acos((Math.Pow(mass[0],2) + Math.Pow(mass[2],2) - Math.Pow(mass[1],2)) / (2 * mass[0] * mass[2])) * 180/ Math.PI),2);
    arr[1] = Math.Round((Math.Acos((Math.Pow(mass[0],2) + Math.Pow(mass[1],2) - Math.Pow(mass[2],2)) / 2 * mass[0] * mass[1]) * 180/ Math.PI),2);
    arr[2] = Math.Round((Math.Acos((Math.Pow(mass[1],2) + Math.Pow(mass[2],2) - Math.Pow(mass[0],2)) / 2 * mass[1] * mass[2]) * 180/ Math.PI),2);
    return anglesArray;


PrintDoubleArray(anglesArray);



// FillDoubleArray(angles, array);
// PrintDoubleArray(angles);

//angles[i] =new ValueOfAngles(array);

Console.WriteLine($"Треугольник является {CheckTriangleCategory(array)} {CheckRightTriangle(angles)}, его улы равны {ValueOfAngles(array)}, периметр равен {PerimetrOfTriangle(array)}, площадь равна{AreaOfTriangle(array)}");