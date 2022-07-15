Console.Write("Set the size of matrix. Set the count of rows: ");
string countOfRows = Console.ReadLine();
Console.Write("Set the size of matrix. Set the count of columns: ");
string countOfColumns = Console.ReadLine();
if (int.TryParse(countOfRows, out int rows) &&
int.TryParse(countOfColumns, out int columns) &&
rows > 1 && columns > 1)
{
    double[,] matrix = new double[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round(new Random().NextDouble() * 10 - 10, 2);
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
else Console.WriteLine("Please, use integers greater than '1'");
