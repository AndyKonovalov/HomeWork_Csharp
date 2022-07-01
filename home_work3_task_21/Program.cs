//Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
Console.Write("Enter the first coordinate of A(x): ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the second coordinate of A(y): ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the third coordinate of A(z): ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the first coordinate of B(x): ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the second coordinate of B(y): ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the third coordinate of B(z): ");
int z2 = Convert.ToInt32(Console.ReadLine());

double dist = Math.Sqrt(Math.Pow(x1 - x2,2) + Math.Pow(y1 - y2,2) + Math.Pow(z1 - z2,2));
Console.WriteLine($"The distance between points A and B is: {dist}");