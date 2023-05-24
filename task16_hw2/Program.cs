// Напишите программу, которая в нход принимает 2 числа
// и проверяет, является ли одно, квадратом другово

Console.Clear();

// тело функций
int Quad (int arg)  // квадрат числа
{
    int quad = arg * arg;
    return quad;
}

void Info (int arg1, int arg2, int arg3)    // вывод проверки квадрата числа (н1, н2, квадра н2)
{
    if (arg1 == arg3)
        {
            Console.WriteLine(arg1 + " является квадратом " + number2);
        }
    else
        {
            Console.WriteLine(arg1 + " НЕ является квадратом " + arg2);
        }
}

// int number1 = new Random().Next(0, 101);  // рандом
// int number2 = new Random().Next(0, 101);  // рандом
// Console.WriteLine("Числа на входе: " + number1 ", " + number2);  // вывод рандома для проверки

Console.WriteLine("Введите число1: ");
int number1 = int.Parse(Console.ReadLine ()!);
Console.WriteLine("Введите число2: ");
int number2 = int.Parse(Console.ReadLine ()!);

Info (number1, number2, Quad(number2)); // решение функцией
Info (number2, number1, Quad(number1)); // решение функцией


// решение в ручную
// int quad1 = number1 * number1;
// int quad2 = number2 * number2;
// if (quad2 == number1)
// {
//     Console.WriteLine("число1: " + number1 + " является квадратом числа2: " + number2);
// }
// else
// {
//     Console.WriteLine("число1: " + number1 + " НЕ является квадратом числа2: " + number2);
// }
// if (quad1 == number2)
// {
//     Console.WriteLine("число2: " + number2 + " является квадратом числа1: " + number1);
// }
// else
// {
//     Console.WriteLine("число2: " + number2 + " НЕ является квадратом числа1: " + number1);
// }