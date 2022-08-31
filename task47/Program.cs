// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


Console.Clear();

Console.WriteLine("Введите число строк m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов n:");
int n = Convert.ToInt32(Console.ReadLine());

if (m == 0 || n == 0)
{
    Console.WriteLine("Невернозаданны параметры матрицы, попробуйте снова");
    return;
}

double[,] CreateMatrixRndDouble(int m, int n)
{
    double[,] matrix = new double[m, n];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {

            matrix[i, j] = Math.Round((rnd.NextDouble()), 1);
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5},");
            else Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine("]");
    }
}

Console.WriteLine($"Двумерный массив m x n: ");
double[,] array2d = CreateMatrixRndDouble(m, n);
PrintMatrix(array2d);