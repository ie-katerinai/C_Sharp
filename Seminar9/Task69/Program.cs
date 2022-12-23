// Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.

Console.WriteLine("Введите основание");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(PowRec(numberA, numberB));


int Pow(int numberA, int numnerB)
{
    int result = 1;
    while (true)
    {
        result *= numberA;
        numnerB--;
        if (numnerB == 0)
            break;
    }
    return result;
}
// int result = 1;
// for (int i = 0;i<numberB;i++)
//     result= result*numberA;



int PowRec(int numberA, int numberB)
{
    if (numberB == 0) return 1;
    return numberA * PowRec(numberA, numberB - 1);
}

// numberA * (numbarA * (numberA*(1)))

// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.WriteLine("Напишите число А");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Напишите число B");
int numB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{Power(numA, numB)}");
Console.WriteLine($"{PowerRec(numA, numB)}");
int Power(int numA, int numB)
{
    int res = 1;
    while (true)
    {
        res = res * numA;
        numB--;
        if (numB == 0)
            break;
    }
    return res;
}

int PowerRec(int numA, int numB)
{
    int res = 1;
    if (numB == 0) return 1;
    res = PowerRec(numA, numB - 1) * numA;


    return res;
}