// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет. 
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет

Console.Write("Set position of element in a row: ");
string row = Console.ReadLine();
Console.Write("Set position of element in a column: ");
string column = Console.ReadLine();
if (int.TryParse(row, out int rowPosition) &&
int.TryParse(column, out int columnPosition) &&
rowPosition >= 0 && columnPosition >= 0)
{
    int[,] matrix = new int[5, 5]; // Можно задать размер, с клавиатуры, но не стал усложнять.
    for (int k = 0; k < matrix.GetLength(0); k++)
    {
        for (int l = 0; l < matrix.GetLength(1); l++)
        {
            matrix[k, l] = new Random().Next(21);
            Console.Write(matrix[k, l] + "\t");
        }
        Console.WriteLine();
    }
    if (rowPosition > 4 || columnPosition > 4)
    {
        Console.WriteLine("The requested matrix element does not exist");
    }
    else Console.WriteLine($"The requested matrix element is {matrix[rowPosition, columnPosition]}");
}
else Console.WriteLine("Please, use positive integers");