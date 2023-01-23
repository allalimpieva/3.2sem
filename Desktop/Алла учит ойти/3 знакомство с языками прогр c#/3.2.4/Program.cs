//Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

Console.Clear();
int a = new Random().Next(8,10);
int b = new Random().Next(0, 4);

Console.WriteLine(a);
Console.WriteLine(b);

if ((((a * a)) == b)|| ((b * b) == a))
{
    Console.WriteLine("одно число является квадратом другого");
}
else
{
    Console.WriteLine("числа не являются квадратами друг друга");
}

