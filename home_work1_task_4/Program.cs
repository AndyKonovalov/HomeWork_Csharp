Console.Write("Enter the thirst number: ");
int thirstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the second number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the third number: ");
int thirdNumber = Convert.ToInt32(Console.ReadLine());

if (thirstNumber > secondNumber)
{
    if (thirstNumber > thirdNumber)
    {
       Console.WriteLine("The thirst number (" + thirstNumber + ") is the maximum"); 
    }
    else
    {
        Console.WriteLine("The third number (" + thirdNumber + ") is the maximum");
    }
}
else
{
    if (secondNumber > thirdNumber)
    {
        Console.WriteLine("The second number (" + secondNumber + ") is the maximum");
    }
    else
    {
        Console.WriteLine("The third number (" + thirdNumber + ") is the maximum"); 
    } 
}