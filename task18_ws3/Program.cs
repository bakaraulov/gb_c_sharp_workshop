// Напишите прогу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y)

Console.Clear();

int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int num = NumExam(value);
    if (num != -1)
    {
        return num;
    }
    else
    {
        return -1;
    }
}

void FindCoordinate(int arg)
{
    if (arg == 1)
    {
        Console.WriteLine("X > 0 и Y > 0");
    }
    else if (arg == 2)
    {
        Console.WriteLine("X < 0 и Y > 0");
    }
    else if (arg == 3)
    {
        Console.WriteLine("X < 0 и Y < 0");
    }
    else if (arg == 4)
    {
        Console.WriteLine("X > 0 и Y < 0");
    }
    else
    {
            Console.WriteLine("Нет такой четверти");
    }
}

int part = Prompt ("Введите номер четверти: ");
FindCoordinate(part);

int NumExam(string arg)
{
    if ((int.TryParse(arg, out int num)) == false)
        {
        Console.WriteLine("Это не число!");
        return -1;
        }
    return num;
}