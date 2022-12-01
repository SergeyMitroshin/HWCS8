/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер
строки с наименьшей суммой элементов: 1 строка
*/

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

int SumRow(int[,] array, int i)
{
    int result = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        result += array[i, j];
    }
    return result;
}

int GetMinRow (int[,] inArray)
{
int result = 0;
int sumRow = SumRow(inArray, 0);
for (int i = 1; i < inArray.GetLength(0); i++)
{
    int tempSumRow = SumRow(inArray, i);
    if (tempSumRow<sumRow)
    {
        sumRow = tempSumRow;
        result = i;
    }
}
return result;
}

Console.Clear();
Console.Write("Введите кол-во строк массива: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов массива: ");
int cols = int.Parse(Console.ReadLine()!);
int[,] array = GetArray(rows, cols, 0, 10);
PrintArray(array);
Console.WriteLine("Строка с наименьшей суммой элементов: " + GetMinRow(array));
