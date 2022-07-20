Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

/// Создает двумерный массив m на n: m - кол-во строк, n - кол-во столбцов.
int[,] FillArray(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = new Random().Next(11);
        }
    }
    return matrix;
}
/// Печатает массив на экран.
void PrintArray(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write(inputArray[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
/// Создает 3 матрицу, размером k на l: k - количество строк l - количество столбцов.
int[,] MultiplyMatrix(int[,] firstArray, int[,] secondArray, int k, int l)
{
    int[,] resultMatrix = new int[k, l];
    for (int i = 0; i < k; i++)
    {
        for (int j = 0; j < l; j++)
        {
            resultMatrix[i, j] = firstArray[i, j] * secondArray[i, j];
        }
    }
    return resultMatrix;
}
Console.Write("\nДаны две матрицы. Необходимо найти произведение двух матриц.\n");
int[,] firstMatrix = FillArray(rows, columns);
PrintArray(firstMatrix);
Console.WriteLine();
int[,] secondMatrix = FillArray(rows, columns);
PrintArray(secondMatrix);
Console.WriteLine("Произведение двух матриц равно:");
int[,] thirdMatrix = MultiplyMatrix(firstMatrix, secondMatrix, rows, columns);
PrintArray(thirdMatrix);