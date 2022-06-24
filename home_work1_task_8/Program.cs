//Console.Write("Enter a number: ");
//int N = Convert.ToInt32(Console.ReadLine());
//int evenN = N % 2;

//if(N <= 1)
//{
//    Console.Write("Enter a number greater than 1");
//}
//while (N > 1)

//if (evenN == 0)
//{
//    Console.Write(N + ";");
//    N = N - 1;
//    evenN = N % 2;
//}
//else
//{
//    N = N - 1;
//    evenN = N % 2;
//}
// Код выше работает наоборот, проверят четность чисел от N до 1 :D

Console.Write("Enter a number: ");
int N = Convert.ToInt32(Console.ReadLine());
int i = 1; // a number between 1 and N
int evenN = i % 2; // even number (четное число)

if (N <= 1)
{
    Console.Write("Enter a number greater than 1");
}
while (i <= N)

if (evenN == 0) //parity check проверка на четность
{
    Console.Write(i + ";");
    i ++;
    evenN = i % 2;
}
else
{
    i ++;
    evenN = i % 2;
}