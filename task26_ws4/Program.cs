// Задача 26: Напишите программу, которая принимает на вход число и 
// выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Clear();

int Prompt(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}


int CountDigit(int number)
{
    int count = 0;
    while (number != 0)
    {
        number = number / 10;
        count++;
        // Console.WriteLine (number + " ");
        // Console.Write (count + " ");
    }
    // Console.Write (count);
    return count;
}

int number = Prompt ("Введите число: ");
Console.WriteLine($"Колличество цифр в числе равно: {CountDigit(number)}");