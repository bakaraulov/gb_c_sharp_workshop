// Напишите программу, которая принимает на вход число (N) и 
// выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 4, 9.
// 5 -> 1, 8, 27, 64, 125

Console.Clear();

// Console.WriteLine("Введите число нуля: ");
// int number1 = int.Parse(Console.ReadLine ()!);

// Console.WriteLine("Выводим все числа от 1 до куба заданного числа... ");
// for (int count = 1; count < Math.Abs(number1); count++)
// {
//     Console.Write(Math.Pow(count, 3) + " ");
// }

int Prompt (string msg)
{
    Console.Write(msg);
    string value = Console.ReadLine();
    if ((int.TryParse(value, out int val)) == false)
    {
        Console.WriteLine("Это не число ");
    }
    Console.WriteLine("Выводим все числа от 1 до куба заданного числа... ");
    return val;
}

void Cubing (int val)
{
    for (int count = 1; count < Math.Abs(val); count++)
    {
        Console.Write(Math.Pow(count, 3) + " ");
    }  
}
int num = Prompt("Введите число: ");
Cubing(num);