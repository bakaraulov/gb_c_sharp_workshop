// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();

int Prompt(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int SumDigit(int number)
{
    int sum = 0;
    for (int i = 1; number>0; i++)
    {
        int digit = number%10;
        number = number/10;
        sum=sum+digit;
        Console.Write(sum + " ");
    }
    return sum;
}

int num = Prompt("Введите число: ");
Console.WriteLine($"Сумма всех чисел равно: {SumDigit(num)}");