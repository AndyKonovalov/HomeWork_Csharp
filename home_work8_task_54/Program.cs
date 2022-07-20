// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[rows, columns];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(11);
        Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine("Отсортированная матрица");
for (int currentRow = 0; currentRow < rows; currentRow++) // текущая строка
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = columns - 1; j > i; j--)
            if (array[currentRow, j] > array[currentRow, j - 1])
            {
                int temp = array[currentRow, j];
                array[currentRow, j] = array[currentRow, j - 1];
                array[currentRow, j - 1] = temp;
            }
    }
}

for (int k = 0; k < rows; k++)
{
    for (int l = 0; l < columns; l++)
    {
        Console.Write(array[k, l] + "\t");
    }
    Console.WriteLine();
}