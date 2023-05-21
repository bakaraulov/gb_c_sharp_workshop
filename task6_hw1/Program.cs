// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)
Console.WriteLine("Введите число1: ");
int number1 = int.Parse(Console.ReadLine ()!);
int rezult = number1 % 2;

if (rezult == 0)
    {
    Console.Write("Введенное число ЯВЛЯЕТСЯ четным");
    }
else
    {
    Console.Write("Введенное число НЕ ЯВЛЯЕТСЯ четным");
    }