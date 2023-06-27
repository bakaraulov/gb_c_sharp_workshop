// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

void PrintMatrix (int[,] matrix)
{
    for (int row = 0 ; row < matrix.GetLength(0) ; row ++)
    {
        for (int colum = 0 ; colum<matrix.GetLength(1) ; colum ++)
        {
            Console.Write($" {matrix [row , colum]}");
        }
    Console.WriteLine();
    }
}

void PrintArray(int[] array) 
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "_");
    }
    Console.WriteLine();
}

int[,] CreateMRandoMatrix (int rows , int colums , int from , int to)
{
    int [,] matrix = new int[rows,colums];
    to ++;
    for (int row = 0 ; row < matrix.GetLength(0) ; row ++)
    {
        for (int colum = 0 ; colum<matrix.GetLength(1) ; colum ++)
        {
            matrix[row,colum] = new Random().Next(from,to);
        }
    }
    return matrix;
}

int[] MinSumMatrixRow (int[,] matrix)
{
    int[] summCol = new int[matrix.GetLength(0)];
    // PrintArray(summCol); debug output
    for (int i = 0 ; i < matrix.GetLength(0) ; i ++)
    {
        int summ = 0;
        for (int j = 0 ; j < matrix.GetLength(1) ; j ++)
        {
            summ = summ + matrix[i,j];
            // Console.WriteLine(summ); debug output
        }
        summCol[i] = summ;
        // Console.Write($"{summCol} ");    debug output
        // Console.WriteLine();
    }
    int minSum = summCol[0];;
    int minI = 0;
    for (int i=0; i<summCol.Length; i++)
    {
        // Console.WriteLine($"Проверка {minSum} , {minI}");    debug output
        if (summCol[i]<minSum)
        {
            minSum = summCol[i];
            minI = i;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Минимальная сумма в {minI+1} строке равна {minSum}");
    Console.WriteLine();
    return summCol;
}

int row = Prompt("Ведите количество строк массива: ");
int col = Prompt("Введите количество столбцов массива: ");
int from = Prompt("Введите начально значение элементов массива: ");
int to = Prompt("Введите конечное значение элементов массива: ");

int[,] matr = CreateMRandoMatrix(row,col,from,to);

Console.WriteLine();
PrintMatrix(matr);
Console.WriteLine();
int[] array = MinSumMatrixRow(matr);
// PrintArray(array);

