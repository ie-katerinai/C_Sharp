/*Задача необязательная FIZZ BUZZ:
Напишите программу, которая выводит на экран числа от 1 до 100.
При этом вместо чисел, кратных трем, программа должна выводить
слово Fizz, а вместо чисел, кратных пяти — слово Buzz.
Если число кратно пятнадцати, то программа должна выводить
слово FizzBuzz. Задача может показаться очевидной,
но нужно получить наиболее простое и красивое решение.*/
using System; 
using System.Diagnostics;
using System.Threading;

void FillArray(int[] mass) // функция для заполнения массива
{
    for (int i = 0; i < mass.Length; i++)
    {
        mass[i] = i + 1;
    }
}
void PrintArray(int[] len) // функция для печати массива
{
    for (int i = 0; i < len.Length; i++)
    {
        // checkArray(len[i]);
        Console.Write(len[i] + " ");
    }
}

Stopwatch stopWatch = new Stopwatch();
        stopWatch.Start();
        
        int[] nullArray = new int[100]; // создание массива из 100 элементов, заполненного 0

FillArray(nullArray); // наполнение массива ЗДЕСЬ

//PrintArray(nullArray);
for (int i = 0; i < nullArray.Length; i++) // цикл для замены цыфр на слова
{
    if (nullArray[i] % 15 == 0)
    {
        Console.Write("FizzBuzz ");
    }
    else if (nullArray[i] % 5 == 0)
    {
        Console.Write("Buzz ");
    }
    else if (nullArray[i] % 3 == 0)
    {
        Console.Write("Fizz ");
    }
    else 
    {
        Console.Write(nullArray[i] + " ");
    }
    
}
 Console.WriteLine();       
        

        //Thread.Sleep(1); // таймер
        stopWatch.Stop();
        // Get the elapsed time as a TimeSpan value.
        TimeSpan ts = stopWatch.Elapsed;

        // Format and display the TimeSpan value.
        string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds);
        Console.WriteLine("RunTime " + elapsedTime);







/*string checkArray(int num)
{
    if (num % 15 == 0)
    {
        string word = "FizzBuzz";
    }
    else if (num % 3 == 0)
    {
        string word = "Fizz";
    }
    else if (num % 5 == 0)
    {
        string word = "Buzz";
    }
    return word;
    //Console.WriteLine($"{massif[index]}");
}*/



// Console.WriteLine();

/*int[] shlepTop = new int[5];
FillArray(shlepTop);
PrintArray(shlepTop);*/
