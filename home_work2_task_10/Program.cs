Console.Write("Enter number a three-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 1 && number <= 99)
{
   Console.WriteLine("The number is not three-digit");
}
else
{
string str = number.ToString();
Console.WriteLine(str[1]);
}