/* Напишите программу, которая принимает на вход целое 
число любой разрядности и проверяет, 
является ли оно палиндромом. 
Через строку нельзя решать само собой. */

void PrintArray(int[] array) // создали массив из нулей
    {
        int count = array.Length;
        for (int pos = 0; pos < count; pos++)
        {
            Console.WriteLine(array[pos]);
        }
    }
void FillArray(int[] col, int num) // заполняет массив реальными цифрами
{
    int length = col.Length;
    int index=length-1;
    while (index >= 0)
    {
        col[index]=num % 10;
        num = num / 10;
        index--;
    }
}
int Digits(int num)
{
int count=0;
while (num > 0)
{
    num=num/10;
    count++;
}
return count;
}
void Palindrome(int[] massif)
{
    int length = massif.Length;
    int i = 0;
    int j = length-1;
    while (i < j)
    {
        if (massif[i] == massif[j])
        {
            i++;
            j--;
            if (j-i == 1 || j-i == 2)
            {
                Console.WriteLine("Число является полиндромом");
            }
        }
            
        else
        {
            Console.WriteLine("Число не является полиндромом");
            break;
        }
    }     
}
try 
{
    Console.WriteLine("Введите число");
    int N = Convert.ToInt32(Console.ReadLine());
    int dig = Digits(N);
    int[] array = new int[dig];
    FillArray(array, N);
    PrintArray(array);
    Palindrome(array);
 }
 catch
 {
     Console.WriteLine("Вы ввели некорректное значение");
 }