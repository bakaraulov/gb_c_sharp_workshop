// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();

int Prompt (string msg)
{
    Console.Write(msg);
    string value = Console.ReadLine();
    int val = 0;
    while ((int.TryParse(value, out val)) != true)
    {
        Console.Write("Неверный ввод. Повторите: ");
        value = Console.ReadLine();
    }
    Console.Clear();
    return val;
}

string PrintNumber1(int number)
{
    if (number == 1) return "1";
    return $"{number} {PrintNumber1(number - 1)} ";
}

string PrintNumber2(int number)
{
    if (number == 1) return "1";

    return $"{PrintNumber2(number - 1)} {number}";
}

int number = Prompt("Введите число: ");
Console.WriteLine(PrintNumber1(number));
Console.WriteLine();
Console.WriteLine(PrintNumber2(number));