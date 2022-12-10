// Задача 39. Напишите программу, которая перевернет зеркально одномерный массив, 
//первый элемент станет последним и так далее

void PrintArray(int[] arr)
{
    Console.WriteLine("Вывод массива");
    foreach (int el in arr)
    {
       Console.Write (el + " "); 
    }
    Console.WriteLine();
}

void FillArray(int[] mass)
{
    int length = mass.Length;
    for (int i = 0; i < length; i++)
    {
        mass[i]=new Random().Next(-20,21);
    }

}

void Reverse(int[] array)
{
    int size = array.Length;
    int temp;
    for (int i = 0; i < size/2; i++)
        {
            temp = array[i];
            array[i] = array[size - 1 - i];
            array[size - 1 - i] = temp;
        }

}


int[] array = new int[10];
FillArray(array);
PrintArray(array);
Console.WriteLine("Перевернутый массив");
Reverse(array);
PrintArray(array);