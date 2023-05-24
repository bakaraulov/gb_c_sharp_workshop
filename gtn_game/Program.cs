// Игра: угадай число (guess the number)

Console.Clear ();
// int value = 43; // ввод числа вручную
int value = new Random().Next(0, 101);  // генератор
int number1 = 0;
int count = 0;

while (value != number1)
    {
    Console.Write("Введите загаданное число: ");
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