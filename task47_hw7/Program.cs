// Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

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

void PrintMatrix (double[,] matrix)
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

double[,] CreateMRandoMatrix (int rows , int colums , int from , int to)
{
    double [,] matrix = new double[rows,colums];
    to ++;
    Random rnd = new Random();
    for (int row = 0 ; row < matrix.GetLength(0) ; row ++)
    {
        for (int colum = 0 ; colum<matrix.GetLength(1) ; colum ++)
        {
            matrix[row,colum] = Math.Round(-42.132 + rnd.NextDouble() * (7.003 + 42.132), 1);

        }
    }
    return matrix;
}

// double[,] CreateMRandoMatrix (int rows , int colums , int from , int to)
// {
//     double[,] matrix = new double[from, to];
//     Random rnd = new Random();
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             // result[i, j] = new Random().Next(minValue, maxValue) / 100.00;
//             matrix[i, j] = rnd.NextDouble();
//             // Console.Write("{0,6:F2}", result[i, j]);
//         }
//     }
//     return matrix;
// }

int row = Prompt("Ведите количество строк массива: ");
int col = Prompt("Введите количество столбцов массива: ");
int from = Prompt("Введите начально значение элементов массива: ");
int to = Prompt("Введите конечное значение элементов массива: ");
double[,] matr = CreateMRandoMatrix(row,col,from,to);
PrintMatrix(matr);