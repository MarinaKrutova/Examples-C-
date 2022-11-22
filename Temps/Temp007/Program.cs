/*
Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

5, 25 -> да
-4, 16 -> да
25, 5 -> да
8,9 -> нет
*/

void SquareOfNumbers(int N1, int N2)
{
    int Max = N1;
    int Min = N2;
     if (N2 > N1) 
     {
        Max = N2;
        Min = N1;
     }
    
    if (Min * Min == Max) Console.WriteLine("Число " + Max + " является квадратом " + Min);
    else Console.WriteLine("Число " + Max + " не является квадратом " + Min);
    
}


int number1 = new int();
int number2 = new int(); 
Console.Write("Введите число 1: ");
number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
number2 = Convert.ToInt32(Console.ReadLine());
SquareOfNumbers(number1, number2);
