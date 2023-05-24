// Напишите программу, которая принимает на вход цифру, обозначающую день недели
// и проверяет, является ли этот день выходным

Console.Clear();

// // в ручную начало
// Console.WriteLine("Введите число, соответствующее дню недели: ");
// int number1 = int.Parse(Console.ReadLine ()!);
// // int number1 = new Random().Next(0, 101);  // рандом
// // Console.WriteLine("Числа на входе: " + number1);  // вывод рандома для проверки
// while (number1 < 0 || number1 > 7)
// {
//     Console.WriteLine("Введено неподходящее число, введите повторно: ");
//     number1 = int.Parse(Console.ReadLine ()!);
// }
// if (number1 == 1)
// {
//     Console.WriteLine("Понедельник, день тяжелый и не выходной");
// }
// else if (number1 > 1 && number1 < 4)
// {
//     Console.WriteLine("Этот день точно не выходной");
// }
// else if (number1 == 5)
// {
//     Console.WriteLine("Пятница - Развратница, хоть и не выходной, но всегда можно таковым сделать!");
// }
// else if (number1 == 6 || number1 == 7)
// {
//     Console.WriteLine("Ура!!! Выходные");
// }
// else
// {
//     Console.WriteLine("Бог еще не сотворил вселенную");
// }
// // в ручную начало

// тела функций
int Prompt (string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

void ExamDay (int arg)
{
    while (arg < 0 || arg > 7)
    {
        Console.WriteLine("Введено неподходящее число, введите повторно: ");
        arg = int.Parse(Console.ReadLine ()!);
    }
    if (arg == 1)
    {
        Console.WriteLine("Понедельник, день тяжелый и не выходной");
    }
    else if (arg > 1 && arg < 4)
    {
        Console.WriteLine("Этот день точно не выходной");
    }
    else if (arg == 5)
    {
        Console.WriteLine("Пятница - Развратница, хоть и не выходной, но всегда можно таковым сделать!");
    }
    else if (arg == 6 || arg == 7)
    {
        Console.WriteLine("Ура!!! Выходные");
    }
    else
    {
        Console.WriteLine("Бог еще не сотворил вселенную");
    }
}

int number1 = Prompt("Введите число, соответствующее дню недели: ");
ExamDay(number1);