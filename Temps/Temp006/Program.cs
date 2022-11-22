/*
Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
сли число 2 не кратно числу 1, то программа выводит остаток от деления.

34, 5 -> не кратно, остаток 4
16, 4 -> кратно
*/

void MultiplicityNumbers(int number1, int number2)
{
    if (number2 % number1 == 0) Console.WriteLine("Число " + number2 + " кратно " + number1);
    else
    Console.WriteLine("Число " + number2 + " не кратно " + number1);
}
int number1 = new int();
int number2 = new int(); 
Console.Write("Введите число 1: ");
number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
number2 = Convert.ToInt32(Console.ReadLine());
MultiplicityNumbers(number1, number2);






