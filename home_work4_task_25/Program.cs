Console.Write("Enter number A: ");
int numbA = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number B: ");
int numbB = Convert.ToInt32(Console.ReadLine());
double numbAPowerOfB = 0;

for (int i = 0; i <= numbB; i++)
{
    numbAPowerOfB = Math.Pow(numbA, i);
}
Console.WriteLine($"The number A to the power of B is {numbAPowerOfB}");


