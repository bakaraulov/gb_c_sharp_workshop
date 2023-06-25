// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

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

void PrintMatrix (int[,,] matrix)
{
    for (int i = 0 ; i < matrix.GetLength(0) ; i ++)
    {
        for (int j = 0 ; j<matrix.GetLength(1) ; j ++)
        {
            for (int l = 0; l<matrix.GetLength(2); l++)
            {
                Console.WriteLine($" Элемент {matrix [i , j , l]} имеет индекс в массиве ({i},{j},{l}) ");
            }
        }
    Console.WriteLine();
    }
}

int[,,] CreateMRandoMatrix (int rows , int colums , int space, int from , int to)
{
    int [,,] matrix = new int[rows,colums,space];
    to ++;
    for (int i = 0 ; i < matrix.GetLength(0) ;i ++)
    {
        for (int j = 0 ; j<matrix.GetLength(1) ; j ++)
        {
            for (int l = 0; l<matrix.GetLength(2); l++)
            {
                matrix[i,j,l] = new Random().Next(from,to);
            
            }
        }
    }
    return matrix;
}

void ExamRandomMatrix(int[,,] matrix3D)
{
    int[] temp = new int[matrix3D.Length];
    int tempNumber;
    for (int i = 0; i < temp.Length; i++)
    {
        temp[i] = new Random().Next(10, 100);
        tempNumber = temp[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (temp[i] == temp[j])
                {
                    temp[i] = new Random().Next(10, 100);
                    j = 0;
                    tempNumber = temp[i];
                }
            }
        }
    }
    int count = 0;
    for (int i = 0; i < matrix3D.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3D.GetLength(1); j++)
        {
            for (int k = 0; k < matrix3D.GetLength(2); k++)
            {
                matrix3D[i,j,k] = temp[count];
                count ++;
            }
        }
    }
}

int row = Prompt("Ведите количество строк массива: ");
int col = Prompt("Введите количество столбцов массива: ");
int space = Prompt("Введите конечное элементов в пространстве массива: ");
int from = Prompt("Введите начальное значение элементов массива: ");
int to = Prompt("Введите конечное значение элементов массива: ");


Console.WriteLine($"Вы ввели: {row} , {col} , {space}, {from} , {to}");
Console.WriteLine();

int[,,] matrix = CreateMRandoMatrix(row,col,space,from,to);
// PrintMatrix(matrix);
Console.WriteLine();

ExamRandomMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();