// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Enter a number: ");
string number = Console.ReadLine();
int [] array = new int [number.Length];
int sum = 0;

for ( int i = 0; i < number.Length; i++)
{
    array[i] = int.Parse(number[i].ToString());
}
for (int i = 0; i < number.Length; i++)
{
    sum += array[i];
}
Console.WriteLine($"Sum of digits in a number {number} = {sum}");
