// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Set parameter b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Set parameter k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Set parameter b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Set parameter k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());
double coordinateX = (b2 - b1)/(k1 - k2); // только при условии, что прямые заданы уравнениями y = k1 * x + b1, y = k2 * x + b2;
double coordinateY = ((b2 - b1)/(k1 - k2)) * k1 + b1; // только при условии, что прямые заданы уравнениями y = k1 * x + b1, y = k2 * x + b2;
Console.WriteLine($"The coordinates of the intersection point of two straight lines are ({coordinateX}; {coordinateY})");