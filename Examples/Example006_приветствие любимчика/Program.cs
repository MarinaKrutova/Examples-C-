Console.Write("Введите имя пользователя: ");
string name = Console.ReadLine();
if (name.ToLower() == "маша")
{
    Console.WriteLine("Ура, это же МАША!");
}
else
{
    Console.WriteLine("Привет, " + name);
}