Console.WriteLine("FIZZ-BUZZ");
Console.WriteLine();
Console.WriteLine();

Console.Write("Enter the limit number:  ");
int limit = Convert.ToInt32(Console.ReadLine());
Console.Write("multiple number1:  ");
int multiple1 = Convert.ToInt32(Console.ReadLine());
Console.Write("multiple number2:  ");
int multiple2 = Convert.ToInt32(Console.ReadLine());

int zeilenUmbruch = 10;

for (int i = 1; i <= limit; i++)
{
    if (i % multiple1 == 0 && i % multiple2 != 0)
    {
        Console.Write("Fizz,  ");
    }
    else if (i % multiple2 == 0 && i % multiple1 != 0)
    {
        Console.Write("Buzz,  ");
    }
    else if (i % multiple1 == 0 && i % multiple2 == 0)
    {
        Console.Write("FizzBuzz,  ");
    }
    else
    {
        Console.Write(i + "  ");
    }
    if (i == zeilenUmbruch)
    {
        Console.WriteLine();
        zeilenUmbruch += 10;
    }
}