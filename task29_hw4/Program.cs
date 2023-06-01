// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

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
string Prompt2 (string msg)
{
    Console.Write(msg);
    string value = Console.ReadLine();
    return value;
}

int[] CreateRandomMassive(int val, int min, int max)
{
    // int [] array = new int [8];
    int [] array = new int [val];
    for (int i=0; i<array.Length; i++)
    {
        array[i] = new Random().Next(min, max);  // генератор [a,b)
        // Console.Write (array[i]+" ");
    }
    return array;
}

int[] CreatemManualMassive(int val)
{
    // int [] array = new int [8];
    int [] array = new int [val];
    for (int i=0; i<array.Length; i++)
    {
        int item = i+1;
        array[i] = Prompt ($"Введите значение {item} элемента: ");
        // Console.Write (array[i]+" ");
    }
    return array;
}

void PrintMassive(int[] array)
{
    for (int i=0; i<array.Length; i++)
    {
        Console.Write (array[i]+" ");
    }
}
string q1 = Prompt2("Вы хотите создать массив в ручную? (Y-да, N-нет): ");

if (q1.ToLower() == "n")
{
    int value = Prompt("Введите длинну массива: ");
    int min = Prompt("Введите значение минимального эл-та массива: ");
    int max = Prompt("Введите значение максимального эл-та массива: ");
    Console.WriteLine ($"{value}, {min}, {max}");
    if (value>0)
    {
        PrintMassive (CreateRandomMassive(value, min, max));
    }
    else
    {
        Console.WriteLine ("Задано неверное число элементов. Нельзя создать массив");
    }
}
else if (q1.ToLower() == "y")
{
    int value = Prompt("Введите длинну массива: ");
    Console.WriteLine ($"{value}");
    if (value>0)
    {
        PrintMassive (CreatemManualMassive(value));
    }
    else
    {
        Console.WriteLine ("Задано неверное число элементов. Нельзя создать массив");
    }
}
else
{
    Console.WriteLine ("Введен неверный символ");
}