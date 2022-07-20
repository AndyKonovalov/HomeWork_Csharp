// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:

Console.Write("Введите количество строк матрицы: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов матрицы: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[rows, columns];
int rowSum = 0;
int[] rowsArray = new int[rows];
int arrIndex = 0;
int minRowSum = 0;
int minRowIndex = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(11);
        Console.Write(matrix[i, j] + "\t");
        rowSum += matrix[i, j];
    }
    Console.WriteLine();
    rowsArray[arrIndex] = rowSum;
    arrIndex++;
    rowSum = 0;
}
Console.WriteLine();

arrIndex = 0;
minRowSum = rowsArray[arrIndex];

for (int i = 1; i < rowsArray.Length; i++)
{
    if (minRowSum > rowsArray[i])
    {
        minRowSum = rowsArray[i];
        minRowIndex = i;
    }
}
Console.WriteLine($"Строка с наименьшей суммой элементов {minRowIndex + 1}");
