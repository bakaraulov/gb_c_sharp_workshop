// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
// элементов в каждом столбце
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого
// столбца: 4,6; 5,6; 3,6; 3.

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

void PrintArray(double[] array) 
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + "_");
    }
    Console.Write(array[array.Length - 1] + " ");
}

void PrintMatrix (int[,] matrix)
{
    for (int i = 0 ; i < matrix.GetLength(0) ; i ++)
    {
        for (int j = 0 ; j<matrix.GetLength(1) ; j ++)
        {
            Console.Write($" {matrix [i , j]}");
        }
    Console.WriteLine();
    }
}

int[,] CreateMRandoMatrix (int rows , int colums , int from , int to)
{
    int [,] matrix = new int[rows,colums];
    to ++;
    for (int i = 0 ; i < matrix.GetLength(0) ; i ++)
    {
        for (int j = 0 ; j<matrix.GetLength(1) ; j ++)
        {
            matrix[i,j] = new Random().Next(from,to);
        }
    }
    return matrix;
}

int row = Prompt("Ведите количество строк массива: ");
int col = Prompt("Введите количество столбцов массива: ");
int from = Prompt("Введите начально значение элементов массива: ");
int to = Prompt("Введите конечное значение элементов массива: ");

int[,] matr = CreateMRandoMatrix(row,col,from,to);
double[] summCol = new double [matr.GetLength(1)];

PrintMatrix(matr);
Console.WriteLine();
PrintArray(summCol);
Console.WriteLine();

for (int j = 0 ; j < matr.GetLength(1) ; j ++)
{
    int summ = 0;
    for (int i = 0 ; i < matr.GetLength(0) ; i ++)
    {
        summ = summ +matr[i,j];
        // Console.Write($"{summ} ");
    }
    // Console.WriteLine();
    // Console.Write($"{summ} ");
    summCol[j] = summ;
    Console.Write($"{summCol} ");
    Console.WriteLine();
}

PrintArray(summCol);
Console.WriteLine();
for (int i = 0;i<summCol.Length;i++)
{
    Console.WriteLine($"Среднее арифметическое {i+1} столбца равно {summCol[i]/matr.GetLength(0)}");
}