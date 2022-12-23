// посчитать сумму всех целых чисел от 1 до N , где N вводится с клавиатуры

Console.WriteLine("Введите целое число");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"сумма чисел от 1 до {N} равна {Summa(N)}");
Console.WriteLine($"сумма чисел от 1 до {N} равна {SummaRec(N)}");

int Summa(int N)
{
    int res=0;
    while (true)
    {
        res+=N;
        N--;
        if (N==0) 
            break;
    }
    return res;
}

int SummaRec(int N)
{
    if (N==0) return 0;
    return N + SummaRec(N-1);
}
