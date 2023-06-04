// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void FillSpiralMatrix(int[,] matrix)               // работает только с квадратными матрицами
{
    int temp = 1;
    for (int delta = 0; delta < matrix.GetLength(0) - 2; delta++)
    {
        for (int i = 0 + delta; i < matrix.GetLength(1) - delta; i++)
        {
            matrix[0 + delta, i] = temp;
            temp++;
        }
        temp--;
        for (int i = 0 + delta; i < matrix.GetLength(0) - delta; i++)
        {
            matrix[i, matrix.GetLength(1) - 1 - delta] = temp;
            temp++;
        }
        temp--;
        for (int i = matrix.GetLength(1) - 1 - delta; i >= 0 + delta; i--)
        {
            matrix[matrix.GetLength(0) - 1 - delta, i] = temp;
            temp++;
        }
        temp--;
        for (int i = matrix.GetLength(0) - 1 - delta; i >= 1 + delta; i--)
        {
            matrix[i, 0 + delta] = temp;
            temp++;
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]} " + "\t");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

System.Console.Write("Введите порядок матрицы: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[n, n];

FillSpiralMatrix(matrix);
PrintMatrix(matrix);