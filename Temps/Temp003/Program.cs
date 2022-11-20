/*
Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа 
в промежутке от -N до N.
4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
2 -> " -2, -1, 0, 1, 2"
*/
int N = new int();
Console.Write ("Введите число: ");
N = Convert.ToInt32 (Console.ReadLine());
int number = -N;
while ( number < N)
{
    Console.Write (number + ", " );
    number = number + 1;
}



Console.WriteLine(number);