Console.Write("Enter a five-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number <= 9999 ^ number >= 100000)
{
    Console.WriteLine("The number is not five-digit");
}
string str = number.ToString();
if (str[0] == str[4] && str [1] == str [3])
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}
// if ((number / 10000 == number % 10) && ((number / 1000) % 10 == (number / 10) % 10))
// {
//     Console.WriteLine((number / 10000 == number % 10) && ((number / 1000) % 10 == (number / 10) % 10));
// }
// else
// {
//     Console.WriteLine((number / 10000 == number % 10) && ((number / 1000) % 10 == (number / 10) % 10));
// }