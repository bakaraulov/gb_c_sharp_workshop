// Задайтедвумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

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
    // Console.Clear();
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

int[,] CreateRandomMatrix (int rows , int colums , int from , int to)
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

int[] MinElementMatrixPosition(int[,] matrix)
{
    int[] resalt = new int[2];
    int minPositionI = 0;
    int minPositionJ = 0;
    int min = matrix[0, 0];
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < min)
            {
                min = matrix[i, j];
                minPositionI = i;
                minPositionJ = j;
            }
        }
    }
    resalt[0] = minPositionI;
    resalt[1] = minPositionJ;
    return resalt;
}

int[,] DeleteRowColumn(int[,] matrix, int[] arr)
{
    int[,] result = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i < arr[0] & j < arr[1]) 
            {
            result[i, j] = matrix[i, j];
            }
            else if (i < arr[0] & j > arr[1]) 
            {
            result[i, j - 1] = matrix[i, j];
            }
            else if (i > arr[0] & j < arr[1]) 
            {
            result[i - 1, j] = matrix[i, j];
            }
            else if (i > arr[0] & j > arr[1]) result[i - 1, j - 1] = matrix[i, j];
        }
    }
    return result;
}



int row = Prompt("Ведите количество строк массива: ");
int col = Prompt("Введите количество столбцов массива: ");
int from = Prompt("Введите начально значение элементов массива: ");
int to = Prompt("Введите конечное значение элементов массива: ");

int[,] matr = CreateRandomMatrix(row, col, from, to);
PrintMatrix(matr);
Console.WriteLine();

int[] minPosition = MinElementMatrixPosition(matr);
Console.Write($"Строка {minPosition[0]+1}; Столбец {minPosition[1]+1}");
Console.WriteLine();

int[,] matr1 = DeleteRowColumn(matr, minPosition);
PrintMatrix(matr1);