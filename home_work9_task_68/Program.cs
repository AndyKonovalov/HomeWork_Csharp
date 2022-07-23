// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9

Console.Write("Введите значение M: ");
int valueM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int valueN = Convert.ToInt32(Console.ReadLine());

if (valueM >= 0 && valueN >= 0)
{
    int akkermanFunction(int m, int n)
    {
        if (m == 0) return n + 1;
        else if (m > 0 && n == 0) return akkermanFunction(m - 1, 1);
        else return akkermanFunction(m - 1, akkermanFunction(m, n - 1)); // m > 0, n > 0
    }
    Console.Write($"Функция Аккермана = {akkermanFunction(valueM, valueN)} ");
}
else Console.WriteLine("M и N должны быть неотрицательными");