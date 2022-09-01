// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


Console.WriteLine("Введите число строк m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов n:");
int n = Convert.ToInt32(Console.ReadLine());

if (m <= 0 || n <= 0)
{
    Console.WriteLine("Неверно заданны параметры матрицы, попробуйте снова");
    return 0;
}

int[,] CreateMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {

            matrix[i, j] = rnd.Next(0, 100);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j]}, 3");
            else Console.Write($"{matrix[i, j]},3");
        }
        Console.WriteLine("]");
    }
}

Console.WriteLine($"Двумерный массив m x n: ");
int[,] array2d = CreateMatrix(m, n);
PrintMatrix(array2d);

// double[] AverageElemsOfColums(double avrgColum, int m, int n);
// {
    
    for (int i = 0; i < n; i++)
    {
        double avrgColum = 0;
                for (int j = 0; j < m; j++)
        {
            avrgColum = avrgColum + array2d[j, i];
            avrgColum = Math.Round(avrgColum / m, 1);
        }
    }
// }

Console.WriteLine($"Среднее арифметическое столбца {m + 1} = {avrgColum}");
// double[] result = AverageElemsOfColums();
Print(avrgColum);


