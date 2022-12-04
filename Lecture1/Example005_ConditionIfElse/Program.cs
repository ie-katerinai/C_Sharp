Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "маша")
{
    Console.WriteLine("Ого! Вот и ты, МАША!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}