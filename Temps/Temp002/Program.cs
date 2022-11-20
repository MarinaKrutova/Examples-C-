/*
Напишите программу, которая будет выдавать название дня недели по заданному номеру.
3 -> Среда
5 -> Пятница
*/
int userNumber = new int();
Console.WriteLine ("Введите число недели: ");
userNumber = Convert.ToInt32 (Console.ReadLine());
if (userNumber == 1)
{
    Console.WriteLine ( "день недели: понедельник" );
}
else if (userNumber == 2)
{
    Console.WriteLine ( "день недели: вторник" );
}
else if (userNumber == 3)
{
    Console.WriteLine ( "день недели: среда" );
}
else if (userNumber == 4)
{
    Console.WriteLine ( "день недели: четверг" );
}
else if (userNumber == 5)
{
    Console.WriteLine ( "день недели: пятница" );
}
else if (userNumber == 6)
{
    Console.WriteLine ( "день недели: суббота" );
}
else if (userNumber == 7)
{
    Console.WriteLine ("день недели: воскресенье");
}
