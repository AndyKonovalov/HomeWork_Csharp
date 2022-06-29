Console.Write("Enter number a number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 1 && number <= 99)
{
    Console.WriteLine("There is no third digit");
}
else
{
    string str = number.ToString();
    Console.WriteLine(str[2]);    
}