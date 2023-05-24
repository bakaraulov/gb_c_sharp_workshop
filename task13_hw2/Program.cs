// Напишите программу, которая выводит 3ю цифру числа
// или что 3й цифры нет

Console.Clear();

// тела функций
int Prompt (string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int FindDigit3 (int arg)
{
    int digit3 = (arg / 100) % 10;
    return digit3;
}

void ExamDigit (int arg1, int arg2)
{
    if (arg1 > -99 && arg1 < 99)
    {
        Console.WriteLine("Третьей цифры в числе: " + arg1 + " нет");
    }
    else
    {
        if (arg1 < 0)
        {
            arg2 = arg2 * -1;
            Console.WriteLine("Третья цифра в веденном числе это: " + arg2);
        }
        else
        {
            Console.WriteLine("Третья цифра в веденном числе это: " + arg2);
        }
    }
}

// // в ручную начало
// Console.WriteLine("Введите число: ");
// int number1 = int.Parse(Console.ReadLine ()!);
// int number1 = new Random().Next(0, 101);  // рандом
// Console.WriteLine("Числа на входе: " + number1);  // вывод рандома для проверки
// int digit3 = (number1 / 100) % 10;
// if (number1 > -99 && number1 < 99)
// {
//     Console.WriteLine("Третьей цифры в числе: " + number1 + " нет");
// }
// else
// {
//     if (number1 < 0)
//     {
//         digit3 = digit3 * -1;
//         Console.WriteLine("Третья цифра в веденном числе это: " + digit3);
//     }
//     else
//     {
//         Console.WriteLine("Третья цифра в веденном числе это: " + digit3);
//     }
// }
// // в ручную конец

int number1 = Prompt("Введите число: ");
ExamDigit(number1,FindDigit3(number1));