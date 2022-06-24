Console.Write("Enter the thirst number: ");
int thirstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the second number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (thirstNumber > secondNumber)
{
    Console.WriteLine("The thirst number (" + thirstNumber + ") is the maximum");
    Console.WriteLine("The second number (" + secondNumber + ") is the minimum");
}
else
{
    Console.WriteLine("The second number (" + secondNumber + ") is the maximum");
    Console.WriteLine("The thirst number (" + thirstNumber + ") is the minimum");
}