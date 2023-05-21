Console.WriteLine("Введите число1: ");
int number1 = int.Parse(Console.ReadLine ()!);
Console.WriteLine("Введите число2: ");
int number2 = int.Parse(Console.ReadLine ()!);
int quad = number2 * number2;
if (quad == number1)
{
    Console.WriteLine("Является");
}
else
{
    Console.WriteLine("Не являетяс");
}