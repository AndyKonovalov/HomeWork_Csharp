Console.Write("Enter number a three-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
int FindSecondDigit(int number)
{
    int secondDigit = (number % 100) / 10;
    return secondDigit;
}
if (number >= 100 && number <= 999)
{
    Console.WriteLine(FindSecondDigit(number));
}
else
{
    Console.WriteLine("The number is not three-digit");
}