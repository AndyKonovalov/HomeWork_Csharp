Console.Write("Enter number a number: ");
int number = Convert.ToInt32(Console.ReadLine());

bool WeekEnd (int number)
{
    return(number == 6 ^ number == 7);
}
if (number >= 1 && number <= 7)
{
    Console.WriteLine(WeekEnd(number));
}
else
{
    Console.WriteLine("Not the day of the week");
}