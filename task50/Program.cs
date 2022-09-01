// Задача 50. Напишите программу, которая 
// на вход принимает позиции элемента в двумерном 
// массиве, и возвращает значение этого элемента 
// или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет


Console.Clear();

Console.WriteLine("Введите число строк m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов n:");
int n = Convert.ToInt32(Console.ReadLine());

if (m == 0 || n == 0)
{
    Console.WriteLine("Неверно заданны параметры матрицы, попробуйте снова");
    return;
}

int [,] CreateMatrix(int m, int n)
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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 3},  ");
            else Console.Write($"{matrix[i, j], 3}");
        }
        Console.WriteLine("]");
    }
}

Console.WriteLine($"Двумерный массив m x n: ");
int[,] array2d = CreateMatrix(m, n);
PrintMatrix(array2d);

Console.WriteLine("Введите координаты элемента (от(1;1))");
Console.Write("Введите координаты X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты Y: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x <= m && x > 0 && y <= m && y > 0)
{
    Console.Write($"{array2d[x - 1, y - 1]} ");
}
else 
{
Console.Write($"В заданном массиве нет элемента с координатами ({x};{y}) ");
}






