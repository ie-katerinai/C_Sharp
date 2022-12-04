// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Требуется ввести число");
int num = Convert.ToInt32(Console.ReadLine());
int rem = num % 2;
if (num == 0)
{
    Console.WriteLine($"Число {num} не является четным или нечетным");
}
else if (rem == 0)
    {
        Console.WriteLine($"Число {num} является четным");
    }
    else Console.WriteLine($"Число {num} является нечетным");