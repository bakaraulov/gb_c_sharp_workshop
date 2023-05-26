// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу квадратов чисел от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.Clear();

// Console.WriteLine("Введите число больше нуля: ");
// int number1 = int.Parse(Console.ReadLine ()!);

// if (number1 > 0)
// {
//     int count = 1;
//     while (count <= number1)
//     {
//     Console.Write(count*count + " ");
//     count ++;    
//     }
// }
// else
// {
//     Console.Write("Введено неверное число");
// }

void QuadNum (int num)
{
    int count = 1;
    while (count <= num)
    {
    Console.Write(count*count + " ");
    count ++;    
    }
}

int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int num = NumExam(value);
    return num;
}

int NumExam(string arg)
{
    if ((int.TryParse(arg, out int num)) == false)
        {
        Console.WriteLine("Это не число!");
        return -1;
        }
    return num;
}

int num = Prompt ("Введите число: ");
if (num != -1)
{
    QuadNum (num);
}
