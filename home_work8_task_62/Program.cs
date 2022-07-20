// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 1  2  3  4
// 12 13 14 5
// 11 16 15 6
// 10 9  8  7

int size = 4;
int element = 1;
int perimeter = 0; // матрица заполняется по периметрам
int[,] matrix = new int[size, size];

for (perimeter = 0; perimeter < size - 2; perimeter++) // 0 - внешний периметр, все что > 0 - внутренний периметр. Количество периметров в матрице 4х4 - 2, поэтому size-2
{
    for (int i = 0 + perimeter; i < size - perimeter; i++) 
    {
        matrix[0 + perimeter, i] = element; // двигаемся вправо по строке
        element++;
    }
    element--;

    for (int i = 0 + perimeter; i < size - perimeter; i++) 
    {
        matrix[i, size - 1 - perimeter] = element; // двигаемся вниз по столбцу
        element++;
    }
    element--;
    for (int i = size - 1 - perimeter; i >= 0 + perimeter; i--)
    {
        matrix[size - 1 - perimeter, i] = element; // двигаемся влево по строке
        element++;
    }
    element--;
    for (int i = size - 1 - perimeter; i >= 1 + perimeter; i--) // двигаемся вверх по столбцу
    {
        matrix[i, 0 + perimeter] = element;
        element++;
    }
}

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}
