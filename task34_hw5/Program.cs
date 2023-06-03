// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве
// [345, 897, 568, 234] -> 2

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

// int[] CreateRandomManMassive(int val, int min, int max)
// {
//     // int [] array = new int [8];
//     int [] array = new int [val];
//     for (int i=0; i<array.Length; i++)
//     {
//         array[i] = new Random().Next(min, max);  // генератор [a,b)
//         // Console.Write (array[i]+" ");
//     }
//     return array;
// }

int[] CreateRandomMassive(int val)
{
    // int [] array = new int [8];
    int [] array = new int [val];
    for (int i=0; i<array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);  // генератор [a,b)
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

void PrintEven(int[] array)
{
    int count2 = 0;
    int count1 = 0;
    for (int i=0; i<array.Length; i++)
    {
        if (array[i]%2 == 0)
        {
            count2++;
        }
        else
        {
            count1++;
        }
    }
    Console.WriteLine ($"Количество четных чисел в массиве равно: {count2} ");
    Console.WriteLine ($"Количество НЕ четных чисел в массиве равно: {count1} ");
}

int value = Prompt("Введите длинну массива: ");
// int min = Prompt("Введите значение минимального эл-та массива: ");
// int max = Prompt("Введите значение максимального эл-та массива: ");
int[] arr = CreateRandomMassive (value);
PrintMassive (arr);
Console.WriteLine (" ");
PrintEven (arr);