int Max(int arg1, int arg2, int arg3)
{ // ищем максимум из трех
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}
int[] array  = {11, 21, 31, 41, 51, 61, 17,18, 19};
//array[0] = 12; // обратились к массиву и записали в него значение
//Console.WriteLine(array[0]); // как можно обратиться к массиву и получить значение

int max = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8])
);
Console.WriteLine(max);