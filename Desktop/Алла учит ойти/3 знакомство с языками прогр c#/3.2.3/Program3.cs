// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

Console.Clear();
Console.Write("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());

if (((a % 7) == 0)&((a % 23) == 0))
{
    Console.WriteLine("число кратно 7 и 23");
}
else
{
    Console.WriteLine("число не кратно 7 и 23");
}