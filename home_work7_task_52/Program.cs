// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Console.Write("Set the size of matrix. Set the count of rows: ");
// string countOfRows = Console.ReadLine();
// Console.Write("Set the size of matrix. Set the count of columns: ");
// string countOfColumns = Console.ReadLine();
// if (int.TryParse(countOfRows, out int rows) &&
// int.TryParse(countOfColumns, out int columns) &&
// rows > 1 && columns > 1)
// {
//     double[,] matrix = new double[rows, columns];
//     double arithmeticAverage = 0;
//     double[] averageArray = new double[columns];
//     double sumColumn = 0;
//     int arrIndex = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(21);
//             Console.Write(matrix[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
//     for (int l = 0; l < matrix.GetLength(1); l++)
//     {
//         for (int k = 0; k < matrix.GetLength(0); k++)
//         {
//             sumColumn += matrix[k, l];
//         }
//         arithmeticAverage = sumColumn / rows;
//         averageArray[arrIndex] = arithmeticAverage;
//         arrIndex++;
//         sumColumn = 0;
//     }
//     Console.Write($"Average of every column is: {String.Join("; ", averageArray)}");

// }
// else Console.WriteLine("Please, use integers greater than '1'");


// double[,] matr = new double[4, 4];
// double summ = 0;
// for (int i = 0; i < matr.GetLength(0); i++)
// {
//     for (int j = 0; j < matr.GetLength(1); j++)
//     {
//         matr[i, j] = new Random().Next(21);
//         Console.Write(matr[i, j] + "\t");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine();
// for (int i = 0; i < matr.GetLength(1); i++)
// {
//     for (int j = 0; j < matr.GetLength(0); j++)
//     {
//         summ += matr[j, i];
//     }
//     Console.WriteLine($"Среднее арифмитическое {i + 1} солбца равно {summ / matr.GetLength(0)}");
// }