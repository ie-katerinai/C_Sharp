/* Напишите программу, которая принимает
на вход координаты двух точек и находит
расстояние между ними в N-мерном пространстве.
Сначала задается N с клавиатуры,
потом задаются координаты точек.*/


try
{
    Console.WriteLine("Введите количество измерений пространства");
    int N = Convert.ToInt32(Console.ReadLine());
    int[] arrayA = new int[N];

    for (int i = 0; i < N; i++)
    {
        Console.WriteLine($"Введите {i + 1} координату точки А");
        arrayA[i] = Convert.ToInt32(Console.ReadLine());
    }
    int[] arrayB = new int[N];

    for (int j = 0; j < N; j++)
    {
        Console.WriteLine($"Введите {j + 1} координату точки B");
        arrayB[j] = Convert.ToInt32(Console.ReadLine());
    }

    void PrintArray(int[] array)
    {
        int count = array.Length;
        int position = 0;
        while (position < count)
        {
            Console.WriteLine(array[position]);
            position++;
        }
    }

    Console.WriteLine();
    Console.WriteLine("Вы ввели следующие координаты точки А");
    PrintArray(arrayA);
    Console.WriteLine();
    Console.WriteLine("Вы ввели следующие координаты точки B");
    PrintArray(arrayB);
    
    double CalcDist(int[] array1, int[] array2)
    {
        double sum = 0;
        for (int i = 0; i < array1.Length; i++)
        {
            double sqr = Math.Pow((arrayB[i] - arrayA[i]), 2);
            sum = sum + sqr;
        }
        double dist = Math.Sqrt(sum);
        return dist;
    }

    double distance = CalcDist(arrayA, arrayB);

    Console.WriteLine();
    Console.WriteLine("Расстояние между точками равно:");
    Console.WriteLine(distance);
}
catch (System.FormatException)
{
    Console.WriteLine("Вы ввели не число");
}
