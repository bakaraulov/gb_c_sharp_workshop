// Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();

int Prompt (string msg)
{
    Console.Write(msg);
    string value = Console.ReadLine();
    if ((int.TryParse(value, out int val)) == false)
    {
        Console.WriteLine("Это не число ");
    }
    return val;
}

int Degree (int arg1, int arg2)
{
    int degree = arg1;
    for (int i = 0; i < Math.Abs(arg2); i++)
    {
        degree = degree*arg1;
        // Console.WriteLine(degree + " ");
        // Console.WriteLine(i + " ");
    }
    return degree;
}

int num1 = Prompt("Введите число1: ");
int num2 = Prompt("Введите число2: ");
int degree = 0;

if (Math.Abs(num2) == 1)
{
    Console.WriteLine($"Возведенное число равно: {num1}");
}
else if (num2>1 || num2<-1)
{
    degree = Degree(num1, num2);
    Console.WriteLine($"c");
}
else
{
    Console.WriteLine($"Возведенное число равно: 1");
}