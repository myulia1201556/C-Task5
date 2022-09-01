// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Введите число строк m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число строк n:");
int n = Convert.ToInt32(Console.ReadLine());

void CreateMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 100);
        }
    }
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
         Console.Write("[ ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
         Console.Write("]");
        Console.WriteLine();
    }
}

double[,] array = new double[m, n];
CreateMatrix(array);
Console.WriteLine($"Двумерный массива размера {m} на {n} имеет вид: ");
PrintMatrix(array);

for (int i = 0; i < n; i++)
{
    double averageColum = 0;
    for (int j = 0; j < m; j++)
    {
        averageColum = averageColum + array[j, i];
    }
    averageColum = Math.Round(averageColum / m, 1);
    Console.WriteLine($"Среднее арифметическое столбца {i + 1} = {averageColum}");
}
