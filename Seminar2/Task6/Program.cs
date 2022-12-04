// Пользователь задает с клавиатуры 6 целых чисел. 
// Надо проверить присутствуют ли там квадраты чисел друг друга. 
// То есть каждое число надо попарно проверять с остальными.
int size = 6;
int[] numbs = new int[size];
for (int i=0; i<size; i++)
{
    Console.WriteLine($"Введите {1+i} число:");
    numbs[i] = Convert.ToInt32(Console.ReadLine());
}
for (int i=0; i<size; i++)
{
    for (int j=0; j<size; j++)
    {
        if(numbs[i]==numbs[j]*numbs[j]) Console.WriteLine($"Число {i+1} является квадратом числа {j+1}");
    }

}
