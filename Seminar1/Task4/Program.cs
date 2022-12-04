// Написать программу, которая на вход принимает N, а на выходе выводит все числа от -N до N 
Console.WriteLine("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());
int n = - num;
while (n <= num)
{
    Console.Write(n + " " );
    n++;
}
