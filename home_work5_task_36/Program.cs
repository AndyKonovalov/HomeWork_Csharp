// Задача 36: Задайте одномерный массив, заполненный 
// случайными числами. Найдите сумму элементов, стоящих 
// на нечётных позициях.
Console.Write("Set the size of the array: ");
string number = Console.ReadLine();
if ((int.TryParse(number, out int size)) && (size > 0))
{
    int[] array = new int[size];
    int sumOfOddIndexElements = 0;
    for (int i = 1; i < size; i += 2)
    {
        array[i] = new Random().Next(-100, 101);
        sumOfOddIndexElements = sumOfOddIndexElements + array[i];    
    }
    Console.WriteLine($"Your array is [{String.Join("; ", array)}]. Sum of all odd index elements in the array = {sumOfOddIndexElements}");
}
else
{
    Console.WriteLine("Entered data is not correct. Please, use positive integers greater than zero");
}