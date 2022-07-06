// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
Console.Write("Set the size of the array: ");
int size = Convert.ToInt32(Console.ReadLine());
int [] array = CreateArray(size);
int [] CreateArray(int size)
{
    int [] array = new int [size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
    return array;
}
Console.WriteLine($"Your array is [{String.Join("; ", array)}]");