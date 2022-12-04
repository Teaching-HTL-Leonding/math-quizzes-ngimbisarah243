Console.ForegroundColor= ConsoleColor.Magenta;
Console.WriteLine("HAILSTONE SEQUENCE");
Console.WriteLine("***************************************");
Console.ResetColor();
Console.WriteLine();
Console.Write("first starting value:  ");
int firstStartingValue = Convert.ToInt32(Console.ReadLine());
Console.Write("second starting value: ");
int secondStartingValue= Convert.ToInt32(Console.ReadLine());

int nOfSequence = firstStartingValue;
int noOfSequence2 = secondStartingValue;
int length1 = 1;
int length2 = 1;

Sequence(nOfSequence,length1);
Sequence(noOfSequence2,length2);

if (length1 > length2) { Console.WriteLine($"{firstStartingValue} has the longer Hailstone sequence"); }
else if (length2 > length1) { Console.WriteLine($"{secondStartingValue} has the longer Hailstone sequence"); }
else if (length1 == length2) { Console.WriteLine($"The length of the Hailstone sequence of the both numbers is equal"); }

void Sequence(int nofsequence,int length)
{
    do
    {
        if (nOfSequence % 2 == 0)
        {
            nOfSequence /= 2;
        }
        else if (nOfSequence % 2 != 0)
        {
            nOfSequence = (3 * nOfSequence) + 1;
        }
        length++;

    } while (nOfSequence! > 1);
}
