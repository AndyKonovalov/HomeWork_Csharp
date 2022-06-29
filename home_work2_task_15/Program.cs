//int number = Convert.ToInt32(Console.ReadLine());
//Console.Write("Enter a number: ");

//bool WeekEnd (int number)
//{
//    return(number == 6 ^ number == 7);
//}
//if (number >= 1 && number <= 7)
//{
//    Console.WriteLine(WeekEnd(number));
//}
//else
//{
//    Console.WriteLine("Not the day of the week");
//}
Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 1 && number <= 7)
{
    if (number == 6 ^ number == 7)
    {
        Console.WriteLine("This is a day off");
    }
    else
    {
        Console.WriteLine("This is not a day off");
    }
}
else
{
    Console.WriteLine("Not the day of the week"); // фича)
}