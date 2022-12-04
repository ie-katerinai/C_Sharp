//  Имеется одномерный массив array из n элементов, 
// требуется найти элемент массива, равный find
int [] array = {1, 2, 3, 9, 4, 5, 6, 7, 8, 9};

int n = array.Length; // возвращает количество элементов массива
int find = 9;

int index = 0;
while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}
