/*
Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

456 -> 46
782 -> 72
918 -> 98
*/
int GetRandomThreeDigitNumber()
{
    return new Random().Next(100, 1000);
}

void RemoveSecondDigitFromNumber(int number)
{
    Console.WriteLine("Исходное число: " + number);
    int firstDigit = number / 100;
    int lastDigit = number % 10;
    Console.WriteLine("Результат: " + firstDigit + lastDigit);
}

int number = GetRandomThreeDigitNumber();
RemoveSecondDigitFromNumber(number);


