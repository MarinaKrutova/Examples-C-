/*
Напишите программу, которая на вход принимает два числа и проверяет, является ли второе число квадратом первого.
a = 5; b = 25 -> да
a = 2 b = 10 -> нет
a = 9; b = -3 -> нет
a = -3 b = 9 -> да
*/
int NumberA = new int ();
int NumberB = new int ();
Console.Write("Введите число1: ");
NumberA = Convert.ToInt32 (Console.ReadLine());
Console.Write("Введите число2: ");
NumberB = Convert.ToInt32 (Console.ReadLine());
bool result = NumberA * NumberA == NumberB;
if (result)
{
    Console.WriteLine("Число " + NumberB + " является квадратом числа " + NumberA);
}
else
{
   Console.WriteLine("Число " + NumberB + " не является квадратом числа " + NumberA);
} 

