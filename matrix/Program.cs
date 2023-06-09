﻿Console.Clear();
Console.WriteLine();

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
    for (int i = 0 ; i < matrix.GetLength(0) ; i ++)
    {
        for (int j = 0 ; j<matrix.GetLength(1) ; j ++)
        {
            Console.Write($"{matrix [i , j]} ");
        }
    Console.WriteLine();
    }
}

int[,] CreateMRandoMatrix (int rows , int colums , int from , int to)
{
    int [,] matrix = new int[rows,colums];
    to ++;
    for (int i = 0 ; i < matrix.GetLength(0) ;i ++)
    {
        for (int j = 0 ; j<matrix.GetLength(1) ; j ++)
        {
            matrix[i,j] = new Random().Next(from,to);
        }
    }
    return matrix;
}

void RotateMatrixClockwise( int[,] matrix, int time)
{
    for(int k = 0; k < time; k++)
    {
        if (matrix.GetLength(0)==matrix.GetLength(1))
        {
            for (int i = 0; i < matrix.GetLength(0) / 2; i++)
            {
                for (int j = i; j < matrix.GetLength(0) - i - 1; j++)
                {
                    int temp = matrix[i, j];
                    matrix[i, j] = matrix[matrix.GetLength(0) - 1 - j, i];
                    matrix[matrix.GetLength(0) - 1 - j, i] = matrix[matrix.GetLength(0) - 1 - i, matrix.GetLength(0) - 1 - j];
                    matrix[matrix.GetLength(0) - 1 - i, matrix.GetLength(0) - 1 - j] = matrix[j, matrix.GetLength(0) - 1 - i];
                    matrix[j, matrix.GetLength(0) - 1 - i] = temp;
                }
            }
        }
        else
        {
            Console.WriteLine("Матрица не квадратна...");
        }
    }
}

void RotateMatrixMainDiagonal(int[,] matrix)
{
    if (matrix.GetLength(0)==matrix.GetLength(1))
    {
        for (int i = 0; i < matrix.GetLength(0); ++i)
        {
            for (int j = 0; j < i; ++j)
                {
                    int temp = matrix[i,j];
                    matrix[i,j] = matrix[j,i];
                    matrix[j,i] = temp;
            }
        }
    }
    else
    {
        Console.WriteLine("Матрица не квадратна...");
    }
}

void RotateMatrixMiddlelColum (int[,] matrix)
{
    if (matrix.GetLength(0)==matrix.GetLength(1))
    {
        for (int i = 0; i < matrix.GetLength(0); ++i)
        {
            for (int j = 0; j < matrix.GetLength(0) / 2; ++j)
            {
                int temp = matrix[i,j];
                matrix[i,j] = matrix[i,matrix.GetLength(0) - j - 1];
                matrix[i,matrix.GetLength(0) - j - 1] = temp;
            }
        }
    }
    else
    {
        Console.WriteLine("Матрица не квадратна...");
    }
}



int row = Prompt("Ведите количество строк массива: ");
int col = Prompt("Введите количество столбцов массива: ");
int from = Prompt("Введите начальное значение элементов массива: ");
int to = Prompt("Введите конечное значение элементов массива: ");
int time = Prompt("Ведите количество поворотов: ");

Console.WriteLine($"Вы ввели: {row} , {col} , {from} , {to} , {time}");
Console.WriteLine();

int[,] matrix = CreateMRandoMatrix(row,col,from,to);
PrintMatrix(matrix);

// RotateMatrixMiddlelColum(matrix);

// RotateMatrixMainDiagonal(matrix);

// RotateMatrixClockwise(matrix,time);

Console.WriteLine();
PrintMatrix(matrix);