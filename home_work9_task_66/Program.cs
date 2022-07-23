// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите значение M: ");
int valueM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int valueN = Convert.ToInt32(Console.ReadLine());

if (valueM != valueN)
{
    if (valueM >= 1)
    {
        if (valueN > valueM)
        {
            int FindSumNumbers(int start, int end)
            {
                if (start == end) return end;
                return (start + FindSumNumbers(start + 1, end));
            }
            Console.WriteLine(FindSumNumbers(valueM, valueN));
        }
        else Console.WriteLine("M должно быть меньше N");
    }
    else Console.WriteLine("M должно быть больше 0");
}
else Console.WriteLine("M не должно равняться N");