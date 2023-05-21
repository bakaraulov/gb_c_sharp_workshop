// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее
Console.WriteLine("Введите число1: ");
int number1 = int.Parse(Console.ReadLine ()!);
Console.WriteLine("Введите число2: ");
int number2 = int.Parse(Console.ReadLine ()!);

if (number1 > number2)
    {
    Console.Write("Первое число больше второго: " + number1 + " > " + number2);
    }
else if (number1 == number2)
    {
    Console.WriteLine("Числа равны друг другу: " + number2 + " = " + number1);
    }
else
    {
    Console.WriteLine("Второе число больше первого: " + number2 + " > " + number1);
    }