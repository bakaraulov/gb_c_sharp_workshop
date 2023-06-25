// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

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

int SumElementMtoN(int m, int n)
{
    if (m == n)
    {
        return m;
    }
    else
    {
        return m + SumElementMtoN(m + 1, n);
    }
    
}

int num1 = Prompt("введите 1-е число: ");
int num2 = Prompt("введите 2-е число: ");

if(num1>num2)
{
    int temp = num1;
    num1 = num2;
    num2 = temp;
}

int sum = SumElementMtoN(num1, num2);
System.Console.WriteLine($"Cуммма натуральных чисел от {num1} до {num2} равна: {sum}");

