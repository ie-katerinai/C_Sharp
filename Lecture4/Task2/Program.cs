
void PrintArray(int[,] matr) // создает матрицу с 0
{
    for (int i = 0; i < matr.GetLength(0); i++) // ---> for (int i = 0; i < 3; i++ ) // щелкающие строки
    {
        for (int j = 0; j < matr.GetLength(1); j++) // ---->for (int j = 0; j < 4; j++) // щелкающие столбцы
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr) //заполняет матрицу случайными числами
{
    for (int i = 0; i < matr.GetLength(0); i++) // ---> for (int i = 0; i < 3; i++ ) // щелкающие строки
    {
        for (int j = 0; j < matr.GetLength(1); j++) // ---->for (int j = 0; j < 4; j++) // щелкающие столбцы
        {
            matr[i,j]= new Random().Next(1, 10);
        }
    }
}

int[,] matrix = new int[3, 4];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
