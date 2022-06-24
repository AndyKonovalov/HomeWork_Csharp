Console.Write("Enter a number: ");
int N = Convert.ToInt32(Console.ReadLine());
int evenN = N % 2;

if (evenN == 0) // parity check проверка на четность
{
    Console.WriteLine("The number (" + N + ") is even"); // четное число
}
else
{
    Console.WriteLine("The number (" + N + ") is uneven"); // нечетное число
}