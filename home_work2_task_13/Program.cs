Console.Write("Enter number a number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 1 && number <= 99)
{
    Console.WriteLine("There is no third digit");
}
if (number >= 100 && number <= 999)
{
    number = number % 10;
    Console.WriteLine(number);
}
if (number >= 1000 && number <= 9999)
{
    number = (number / 10) % 10;
    Console.WriteLine(number);
}
if (number >= 10000 && number <= 99999)
{
    number = (number / 100) % 10;
    Console.WriteLine(number);
}
else
{
    Console.WriteLine("You have exceeded the value of 99999");
}