﻿// Задача 62 *** Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

﻿// Задача 62: Заполните спирально массив 4 на 4.(это мы розобрали на семинаре)
// Написал прогрпмму которая заполняет массив любой розмерности

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

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($" {matrix[i, j]}");
        }
        Console.WriteLine();
    }
}

void SpiralCreateMatrix(int[,] matrix)
{
    int value = 1;
    int i = 0;
    int j = 0;
    if (matrix.GetLength(0) == matrix.GetLength(1))
    {
        while (value <= matrix.Length)
        {
            matrix[i, j] = value;
            if (i <= j + 1 && i + j < matrix.GetLength(1) - 1) j++;
            else if (i < j && i + j >= matrix.GetLength(0) - 1) i++;
            else if (i >= j && i + j > matrix.GetLength(1) - 1) j--;
            else i--;
            value++;
        }
    }
    else if (matrix.GetLength(0) < matrix.GetLength(1))
    {
        int n = 0;
        while (value <= matrix.Length)
        {
            matrix[i, j] = value;
            if (i == n && j < matrix.GetLength(1) - 1 - n) j++;
            else if (j == matrix.GetLength(1) - 1 - n && i < matrix.GetLength(0) - 1 - n) i++;
            else if (j == matrix.GetLength(1) - 1 - n && i == matrix.GetLength(0) - 1 - n)
            {
                n++;
                value--;
            }
            else if (n == matrix.GetLength(0) / 2)
            {
                n++;
                value--;
            }
            else if (i == matrix.GetLength(0) - n && j > n - 1) j--;
            else if (i > n && j <= matrix.GetLength(1) - n) i--;
            else j--;
            value++;
        }

    }
    else if (matrix.GetLength(0) > matrix.GetLength(1))
    {
        int n = 0;
        while (value <= matrix.Length)
        {
            matrix[i, j] = value;
            if (i == n && j < matrix.GetLength(1) - 1 - n) j++;
            else if (j == matrix.GetLength(1) - 1 - n && i < matrix.GetLength(0) - 1 - n) i++;
            else if (j == matrix.GetLength(1) - 1 - n && i == matrix.GetLength(0) - 1 - n)
            {
                n++;
                value--;
            }
            else if (i == matrix.GetLength(0) - n && j > n - 1) j--;
            else if (i > n && j <= matrix.GetLength(1) - n) i--;
            else i--;
            value++;
        }

    }

}

Console.Clear();
int row = Prompt("Ведите количество строк массива: ");
int col = Prompt("Введите количество столбцов массива: ");
int[,] matr = new int[row, col];
SpiralCreateMatrix(matr);
PrintMatrix(matr);