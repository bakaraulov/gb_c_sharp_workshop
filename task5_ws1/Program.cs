// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N
// (C) Елена, Анатолий, Алексей, Борис
Console.WriteLine("Введите число: ");
int number1 = int.Parse(Console.ReadLine ()!);
int number2 = number1 * -1;
int temp;

if ( number1 < 0)
    {
    temp = number1;
    number1 = number2;
    number2 = temp;
    }
while (number2 <= number1)
    {
        Console.Write(number2 + " ");
        number2 += 1;
    }
