// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить
// произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

void FillMatrixWhithRandomNumbers(int[,] matrix)
{
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(0, 10);
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

void MultiplyMatrix(int[,] matrix1, int[,] matrix2, int[,] resultmatrix)
{
    for (int i = 0; i < resultmatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultmatrix.GetLength(1); j++)
        {
            for (int s = 0; s < matrix2.GetLength(0); s++)
            {
                resultmatrix[i,j] += matrix1[i,s] * matrix2[s,j];
            }
        }
    }
}

System.Console.Write("Введите количество строк массива1: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов массива1 и строк массива2(согласованные матрицы): ");   // Операция умножения двух матриц выполнима только в том случае, если число столбцов в первом сомножителе равно числу строк во втором; в этом случае говорят, что матрицы согласованы
int n = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов массива2: ");
int k = Convert.ToInt32(Console.ReadLine());

int[,] matrix1 = new int[m, n];
int[,] matrix2 = new int[n, k];
int[,] resultmatrix = new int[m, k];

FillMatrixWhithRandomNumbers(matrix1);
PrintMatrix(matrix1);
FillMatrixWhithRandomNumbers(matrix2);
PrintMatrix(matrix2);

MultiplyMatrix(matrix1, matrix2, resultmatrix);
PrintMatrix(resultmatrix);