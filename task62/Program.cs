// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void FillMatrixSpiralMethod(int[,]matrix)
{
int row = 0;
int col = 0;
int dx = 1;
int dy = 0;
int dirChanges = 0;
int visits = matrix.GetLength(1);
 
for (int i = 0; i < matrix.Length; i++)
{
    matrix[row, col] = i + 1;
    if (--visits == 0)
    {
        visits = matrix.GetLength(1) * (dirChanges %2) + matrix.GetLength(0) * ((dirChanges + 1) %2) - (dirChanges/2 - 1) - 2;
        int temp = dx;
        dx = -dy;
        dy = temp;
        dirChanges++;
    }
    col += dx;
    row += dy;
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

System.Console.Write("Введите количество строк массива: ");
int n = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите количество столбцов массива: ");
int m = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[n,m];

FillMatrixSpiralMethod(matrix);
PrintMatrix(matrix);