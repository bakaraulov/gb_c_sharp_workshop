// Напишите программу, которая принимает в нход 3х значное число
// на выходе показывает 2ую цифру числа

//Console.Clear();

// тело функций
int FindDigit1 (int arg)    //  поиск первой цифры
{
    int digit = arg / 100;
    return digit;
}

int FindDigit2 (int arg)    //  поиск второй цифры
{
    int digit = (arg / 10) % 10;
    return digit;
}

int FindDigit3 (int arg)    //  поиск третьей цифры
{
    int digit = arg % 10;
    return digit;
}

int ExamDigit (int arg)
{
    while (arg > 1000 || arg < 100)
    {
        if (arg < 100)
        {
            Console.WriteLine("Введенное число меньшего порядка, чем требуется...");
            Console.WriteLine("Введите трехзначное число: ");
            arg = int.Parse(Console.ReadLine ()!);
    }
    else
    {
            Console.WriteLine("Введенное число большего порядка, чем требуется...");
            Console.WriteLine("Введите трехзначное число: ");
            arg = int.Parse(Console.ReadLine ()!);
    }
    }
    return arg;
}


// int number1 = new Random().Next(0, 101);  // рандом
// Console.WriteLine("Числа на входе: " + number1);  // вывод рандома для проверки

Console.WriteLine("Введите трехзначное число: ");
int number1 = int.Parse(Console.ReadLine ()!);

// // решение в ручную начало
// while (number1 > 1000 || number1 < 100)
// {
//     if (number1 < 100)
//     {
//         Console.WriteLine("Введенное число меньшего порядка, чем требуется...");
//         Console.WriteLine("Введите трехзначное число: ");
//         number1 = int.Parse(Console.ReadLine ()!);
//     }
//     else
//     {
//         Console.WriteLine("Введенное число большего порядка, чем требуется...");
//         Console.WriteLine("Введите трехзначное число: ");
//         number1 = int.Parse(Console.ReadLine ()!);
//     }
// }
// int digit1 = number1 / 100;
// int digit2 = (number1 / 10) % 10;
// int digit3 = number1 % 10;

// Console.WriteLine("Разбиваем по цифрам... " + digit1 + " , " + digit2 + " , " + digit3);
// Console.WriteLine("Искомая цифра: " + digit2);
// // решение в ручную конец

number1 = ExamDigit(number1);
Console.WriteLine("Разбиваем по цифрам... " + FindDigit1(number1) + " , " + FindDigit2(number1) + " , " + FindDigit3(number1));
Console.WriteLine("Искомая цифра: " + FindDigit2(number1));