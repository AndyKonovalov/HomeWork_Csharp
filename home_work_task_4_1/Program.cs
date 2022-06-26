Console.Write("Enter the thirst number: ");
int thirstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the second number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the third number: ");
int thirdNumber = Convert.ToInt32(Console.ReadLine());

int maxNumber = thirstNumber;

if (secondNumber > maxNumber) maxNumber = secondNumber;
if (thirdNumber > maxNumber) maxNumber = thirdNumber;
{
    Console.WriteLine("Maximum number is " + maxNumber);
}