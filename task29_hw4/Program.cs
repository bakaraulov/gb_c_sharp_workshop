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

int[] CreateRandomMassive(int val)
{
    // int [] array = new int [8];
    int [] array = new int [val];
    for (int i=0; i<array.Length; i++)
    {
        array[i] = new Random().Next(0, 2);  // генератор [a,b)
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

int value = Prompt("Введите число ");
Console.WriteLine (value);
if (value>0)
{
    PrintMassive (CreateRandomMassive(value));
}
else
{
    Console.WriteLine ("Задано неверное число элементов. Нельзя создать массив");
}