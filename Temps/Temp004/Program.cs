﻿/*
Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру 
этого числа.
456 -> 6
782 -> 2
918 -> 8
*/
int userNumber = new int();
Console.Write ("Введите трехзначное число: ");
userNumber = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Последняя цифра Вашего числа: " + userNumber % 10);