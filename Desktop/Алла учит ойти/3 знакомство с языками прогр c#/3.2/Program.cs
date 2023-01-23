
/*
 Напишите программу, которая будет принимать на вход два числа и выводить, 
является ли второе число кратным первому. Если число 2 не кратно числу 1, 
то программа выводит остаток от деления.
*/

Console.Clear();

int a = new Random().Next(10, 1000);
int b = new Random().Next(10, 1000);
Console.WriteLine (a);
Console.WriteLine (b);

int c = (a % b);

if (c == 0)
{
    Console.WriteLine("число 2 кратно числу 1");
}
else
{
    Console.WriteLine("число 2 не кратное, остаток " + c);
}
