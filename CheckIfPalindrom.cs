Console.WriteLine("CHECK IF PALINDROME");
Console.WriteLine();
Console.WriteLine();

Console.Write("Enter a positive integer number:  ");
int number = Convert.ToInt32(Console.ReadLine());

int enteredNumber = number;
int rest;
int sum = 0;

while (number > 0)
{
    rest = number % 10;
    sum = (sum * 10) + rest;
    number /= 10;
}
if (enteredNumber == sum)
{
    Console.WriteLine("Palindrom");
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("NO ");
    Console.ResetColor();
    Console.WriteLine("Palindrom");
}
