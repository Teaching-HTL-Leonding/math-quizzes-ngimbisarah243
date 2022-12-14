
Console.Write("first number:  ");
double firstNumber = Convert.ToDouble(Console.ReadLine());
Console.Write("second number: ");
double secondNumber = Convert.ToDouble(Console.ReadLine());
Console.Write("result:        ");
double result = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();

if (firstNumber + secondNumber == result )
{
    Console.WriteLine("Plus");
}
else if (firstNumber * secondNumber == result )
{
    Console.WriteLine("Multiply");
}
else if (firstNumber / secondNumber ==(int) result || secondNumber / firstNumber == (int)result)
{
    Console.WriteLine("Divide");
}
else if (firstNumber % secondNumber == result || secondNumber % firstNumber == result)
{
    Console.WriteLine("Modulo");
}
else if (Math.Pow(firstNumber, secondNumber) == result || Math.Pow(secondNumber,firstNumber)== result)
{
    Console.WriteLine("Expontentiation");
}

Console.Clear();

