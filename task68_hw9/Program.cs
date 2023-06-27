// Задача 68: Напишите программу вычисления функции Аккермана с помощью
// рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

Console.Clear();

int Prompt (string msg)
{
    Console.Write(msg);
    string value = Console.ReadLine();
    int val = 0;
    while ((int.TryParse(value, out val)) != true)
    {
        Console.Write("Неверный ввод. Повторите: ");
        value = Console.ReadLine();
    }
    Console.Clear();
    return val;
}

int Ackermann (int m, int n)
{
    if (m == 0) 
    {
        return n+ 1;
    }
    else if (m != 0 && n == 0) 
    {
        return Ackermann(m - 1, 1);
    }
    else
    {
        return Ackermann(m - 1, Ackermann(m, n - 1));
    }
}

int num1 = Prompt("введите 1-е число: ");
int num2 = Prompt("введите 2-е число: ");

if (num1<0) num1 = num1*-1;
if (num2<0) num2 = num2*-1;

int ackermann = Ackermann(num1, num2);
Console.WriteLine($"Результат функции Аккермана для чисел {num1} и {num2} равен: {ackermann}");