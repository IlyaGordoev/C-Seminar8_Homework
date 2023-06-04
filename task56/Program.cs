// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая
// будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2   14 минимальная первая строка
// 5 9 2 3   19
// 8 4 2 4   18
// 5 2 6 7   20
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с
// наименьшей суммой элементов: 1 строка

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

void SumRowMatrix(int[,] matrix, int[] array)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i,j];
        }
        array[i] = sum;
    }
}

void MinArrayIndex(int[] array)
{
    int min = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < array[min])
        {
            min = i;
        }
    }
    System.Console.WriteLine($" наименьшей суммой элементов: {min+1} строка");
}

System.Console.Write("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[m, n];
int[] array = new int[m];

FillMatrixWhithRandomNumbers(matrix);
PrintMatrix(matrix);
System.Console.WriteLine();

SumRowMatrix(matrix, array);
MinArrayIndex(array);