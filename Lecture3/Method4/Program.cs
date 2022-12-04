// Вид 4ю Метод, который что-то принемает и что-то возвращают

string Method4(int count, string text) // сколько раз и какой текст
{
    int i=0; // инициализация счетчика
    string result = String.Empty; 
    // или можно  "" добавить пустую строку, которую потом заполним введеннной стрингой;
    while (i < count)
    {
        result = result + text; // пустая строка плюс текст,
        i++;
    }
    return result;
}

string res = Method4(10, "TeXt"); // Вызов функции через присвоение переменной метода
Console.WriteLine(res);