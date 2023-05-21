// Напишите программу, которая принимает на вход трехзначное число и на выходе показывает последнюю цифру этого числа
// (C) Елена, Анатолий, Алексей, Борис
Console.WriteLine("Введите трехзначное число: ");
int number1 = int.Parse(Console.ReadLine ()!);
int result = number1 % 10;
Console.WriteLine(result);