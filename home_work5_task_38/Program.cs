// Задача 38: Задайте массив вещественных чисел. Найдите 
// разницу между максимальным и минимальным 
// элементов массива.
Console.Write("Set the size of the array: ");
string number = Console.ReadLine();
if ((int.TryParse(number, out int size)) && (size > 0))
{
    double[] array = new double[size];
    double min = 0;
    double max = 0;
    double MinOfArray(double min)
    {
        for (int i = 0; i < size; i++)
        {
            if (array[i] < min) min = array[i];
        }
        return min;
    }
    double MaxOfArray(double max)
    {
        for (int i = 0; i < size; i++)
        {
            if (array[i] > max) max = array[i];
        }
        return max;
    }
    double diffMaxMin = 0;
    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round(new Random().NextDouble() * 40 - 20, 2);
    }
    Console.WriteLine(MaxOfArray(max));
    Console.WriteLine(MinOfArray(min));
    diffMaxMin = Math.Round(MaxOfArray(max) - MinOfArray(min), 2);
    Console.WriteLine($"Your array is [{String.Join("; ", array)}]. The difference between the maximum and minimum elements of the array = {diffMaxMin}");
}
else
{
    Console.WriteLine("Entered data is not correct. Please, use positive integers greater than zero");
}