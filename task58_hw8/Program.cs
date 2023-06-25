// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] MultuMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] multimatrix = new int[matrix1.GetLength(0),matrix2.GetLength(1)];
    if (matrix1.GetLength(1) != matrix2.GetLength(0))
    {
        Console.WriteLine("Такие матрицы нельзя перемножить, так как количество столбцов матрицы А не равно количеству строк матрицы В");
    }
    else
    {
        int sum = 0;
        for (int i = 0 ; i < matrix1.GetLength(0) ; i ++)
        {
            for (int j = 0 ; j< matrix2.GetLength(1) ; j ++)
            { 
                for (int m = 0 ; m< matrix2.GetLength(0) ; m ++)
                {
                    multimatrix[i,j] = multimatrix[i,j] + matrix1[i,m] * matrix2[m,j];
                }
            }
        }
    }
    return multimatrix;
}

int row1 = Prompt("Ведите количество строк 1 массивов: ");
int col1 = Prompt("Введите количество столбцов 1 массивов: ");
int row2 = Prompt("Ведите количество строк 2 массивов: ");
int col2 = Prompt("Введите количество столбцов 2 массивов: ");
int from1 = Prompt("Введите начально значение элементов массива: ");
int to1 = Prompt("Введите конечное значение элементов массива: ");
// int from2 = Prompt("Введите начально значение элементов 2 массива: ");
// int to2 = Prompt("Введите конечное значение элементов 2 массива: ");

int[,] matr1 = CreateMRandoMatrix(row1,col1,from1,to1);
int[,] matr2 = CreateMRandoMatrix(row2,col2,from1,to1);

Console.WriteLine();
PrintMatrix(matr1);
Console.WriteLine();
PrintMatrix(matr2);

int[,] multimatr = MultuMatrix(matr1, matr2);

Console.WriteLine("Матрица перемножения...");
PrintMatrix(multimatr);