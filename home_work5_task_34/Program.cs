// Задача 34: Задайте массив заполненный случайными 
// положительными трёхзначными числами. Напишите 
// программу, которая покажет количество чётных чисел в 
// массиве.
Console.Write("Set the size of the array: ");
string number = Console.ReadLine();
if (int.TryParse(number, out int size))
{
    int[] array = new int[size];
    int countEvenNumbers = 0;
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
        if (array[i] % 2 == 0)
        {
            countEvenNumbers++;
        }
    }
    Console.WriteLine($"Your array is [{String.Join("; ", array)}]. Count of even numbers in the array = {countEvenNumbers}");
}
else
{
    Console.WriteLine("Entered data is not a number. Please, use integers");
}