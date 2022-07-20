// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)
Console.Write("Введите высоту массива: ");
string coordinateZ = Console.ReadLine();
Console.Write("Введите длину массива: ");
string coordinateX = Console.ReadLine();
Console.Write("Введите ширину массива: ");
string coordinateY = Console.ReadLine();
if (coordinateZ != "" && coordinateX != "" && coordinateY != "")
{
    if (int.TryParse(coordinateZ, out int height) &&
    int.TryParse(coordinateX, out int length) &&
    int.TryParse(coordinateY, out int width))
    {
        if (height >= 2 && length >= 2 && width >= 2)
        {
            int[,,] threeDimensionArray = new int[height, length, width];
            for (int i = 0; i < threeDimensionArray.GetLength(0); i++) // Z
            {
                for (int j = 0; j < threeDimensionArray.GetLength(1); j++) // X
                {
                    for (int k = 0; k < threeDimensionArray.GetLength(2); k++) // Y
                    {
                        threeDimensionArray[i, j, k] = new Random().Next(10, 100);
                        Console.Write(threeDimensionArray[i, j, k] + "(" + i + ", " + j + ", " + k + ")" + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }else Console.WriteLine("Количество строк и столбцов не может быть отрицательным и должно быть больше 1");
    }
    else Console.WriteLine("Ошибка ввода. Некорректное число!");
}
else Console.WriteLine("Ошибка ввода. Пустая строка");