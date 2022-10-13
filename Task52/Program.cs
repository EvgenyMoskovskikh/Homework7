// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.Write("Введите количество строк: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(m, n, 0, 10);
PrintArray(array);

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return (result);
}

double[] Sum(int[,] array)
{
    double[] sr = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
            sr[j] += array[i, j];
        sr[j] /= array.GetLength(0);
    }
    return sr;
}

double[] srM = Sum(array);
for (int i = 0; i < srM.Length; i++)
    Console.Write($"{Math.Round(srM[i],2)} ");

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

// void Sr(int[,] array)
// {
//     for (int j=0; j<array.GetLength(1);j++)
//     {
//         double sr = 0;
//         for(int i=0; i<array.GetLength(0);i++)
//             sr += array[i,j];
//         sr /= array.GetLength(0);
//         Console.Write(Math.Round(sr,2) + " ");
//     }
//     Console.WriteLine();
// }

// Sr(array);
