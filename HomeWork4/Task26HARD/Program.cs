// Задача 26. - HARD необязательная
// Напишите программу, которая принимает на вход целое или дробное число и выдаёт количество цифр в числе.
// 452 -> 3
// 82 -> 2
// 9,012 ->4

long ConvToInteger(decimal num1) // функция домнажает дробное число до целого
{
    decimal fraction = num1;
    long result = 0;
    if (num1 > -1 && num1 < 1)
    {
        int count1 = 0;
        while (fraction != 0) // условие: пока дробная часть не будет равна 0
        {
            num1 = num1 * 10;
            fraction = num1 % 1;
            count1++;
        }
        result = count1;
    }
    else
    {
        while (fraction != 0) // условие: пока дробная часть не будет равна 0
        {
            num1 = num1 * 10;
            fraction = num1 % 1;
        }
        long integer = Convert.ToInt64(num1 - fraction); // переврдим в int, чтобы после запятой не писались нули, 64 - чтобы можно было ввести число больше 10 знаков
        //Console.WriteLine($"Число дробное, увеличенное до целого {integer}");
        result = integer;
    }
    return result;
}

int CountingNumbers(long num2) // функция подсчета количества цифр в числе
{
    int count = 0; // обнуление счетчика
    while (num2 != 0)
    {
        num2 = num2 / 10;
        count++;
    }
    //Console.WriteLine($"Количество цифр {count}");
    return count;
}

try
{
    Console.WriteLine("Введите число "); // вывод запроса пользователю
    decimal N = Convert.ToDecimal(Console.ReadLine()); // конвертирование и запись дробного значения в переменную
    if (N > -1 && N < 1)
    {
        long integer = (ConvToInteger(N) + 1);
        Console.WriteLine(integer);
    }
    else
    {
        long integer = ConvToInteger(N);
        Console.WriteLine($"Количестыо цифр в числе: {CountingNumbers(integer)}");
    }
}
catch (System.FormatException) // ищет неверный формат ввоа
{
    Console.WriteLine("Вы ввели не число");
}

// Console.WriteLine("Введите число "); // вывод запроса пользователю
// decimal N = Convert.ToDecimal(Console.ReadLine()); // конвертирование и запись дробного значения в переменную

// decimal fraction = N % 1; // отеление дробной части от целой
// int integer = Convert.ToInt32(N - fraction); // отеление целой части от робной

// Console.WriteLine($"Целая часть {integer} равна , дробная часть равна {fraction}");
