// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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
        array[i] = new Random().Next(0, 100);  // генератор [a,b)
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

void PrintEvenSum(int[] array)
{
    int sum2 = 0;
    int sum1 = 0;
    for (int i=0; i<array.Length; i++)
    {
        if (i%2!=0)
        {
            sum2+=array[i];
        }
        else
        {
            sum1+=array[i];
        }
    }
    Console.WriteLine (" ");
    Console.WriteLine ($"Сумма элементов с четным индексом равна: {sum2} ");
    Console.WriteLine ($"Сумма элементов с НЕ четным индексом равна: {sum1} ");
}

int value = Prompt("Введите длинну массива: ");
int[] array = CreateRandomMassive(value);
PrintMassive(array);
PrintEvenSum(array);