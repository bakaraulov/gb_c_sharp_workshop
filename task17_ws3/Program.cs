// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

int x1 = Prompt("Введите координату X: ");
int y1 = Prompt("Введите координату Y: ");
FindCoordinate(x1, y1);

int x2 = Prompt("Введите координату X: ");
int y2 = Prompt("Введите координату Y: ");
FindCoordinate(x2, y2);

int Prompt(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}

void FindCoordinate(int x, int y)
{
    if (x > 0 && y > 0)
    {
        Console.WriteLine("I четверть");
    }
    if (x < 0 && y > 0)
    {
        Console.WriteLine("II четверть");
    }
    if (x < 0 && y < 0)
    {
        Console.WriteLine("III четверть");
    }
    if (x > 0 && y < 0)
    {
        Console.WriteLine("IV четверть");
    }
}