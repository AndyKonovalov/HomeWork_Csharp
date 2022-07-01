// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Write("Enter a five-digit number: ");
string number = Console.ReadLine();
int numberLength = number.Length; // just like array.Length
if (numberLength <= 4 ^ numberLength >= 6) // five-digit number length = 5, feature
{
    Console.WriteLine("The number is not five-digit");
}
else
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine("This is a palindrome");
    }
    else 
    {
        Console.WriteLine("This is not a palindrome");
    }
}