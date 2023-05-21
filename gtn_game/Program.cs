// Игра: угадай число (guess the number)
int value = 43; // число, которое необходимо угодять
int number1 = 0;
int count = 0;

while (value != number1)
    {
    Console.WriteLine("Введите загаданное число: ");
    number1 = int.Parse(Console.ReadLine ()!);
    count += 1;
    if (value == number1)
        {
        Console.WriteLine("Вы угодали c " + count + " попытки. Загаданное число равно: " + value);
        }
    else if (value < number1)
        {
        Console.WriteLine("Не угодали. Загаданное число меньше. Повторите попытку.");
        }
    else
        {
        Console.WriteLine("Не угодали. Загаданное число больше. Повторите попытку.");
        }
    }
Console.WriteLine(" Спасибо за игру");