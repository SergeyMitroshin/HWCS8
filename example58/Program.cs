/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
// принимаем,что обе матрицы - квадратные одинакового размера.

int[,] GetArray(int m, int n, int minValue, int maxValue) 
{
    int[,] result = new int[m, n];
    Random rand = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = rand.Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

int[,] MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix)
{
    int size = firstMartrix.GetLength(0);
    int[,] result = new int [size,size];
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            int sum = 0;
            for (int k = 0; k < size; k++)
            {
                sum += firstMartrix[i, k] * secomdMartrix[k, j];
            }
            result[i, j] = sum;
        }
    }
   return result; 
}


Console.Clear();
Console.Write("Введите размерность матриц: ");
int rows = int.Parse(Console.ReadLine()!);
int[,] matrix1 = GetArray(rows, rows, 0, 10);
Console.WriteLine("Матрица 1:");
PrintArray(matrix1);
int[,] matrix2 = GetArray(rows, rows, 0, 10);
Console.WriteLine("Матрица 2:");
PrintArray(matrix2);
Console.WriteLine("Произведение матриц:");
PrintArray(MultiplyMatrix(matrix1,matrix2));