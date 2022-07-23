// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

Console.Write("Введите значение M: ");
int valueM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int valueN = Convert.ToInt32(Console.ReadLine());

if (valueM != valueN && valueM >= 1)
{
    if (valueM >= 1)
    {
        if (valueN > valueM)
        {
            string FindNumbers(int start, int end)
            {
                if (start == end) return start.ToString();
                return (start + ", " + FindNumbers(start + 1, end));
            }
            Console.WriteLine(FindNumbers(valueM, valueN));
        }
        else Console.WriteLine("M должно быть меньше N");
    }
    else Console.WriteLine("M должно быть больше 0");
}
else Console.WriteLine("M не должно равняться N и должно быть больше 0");

