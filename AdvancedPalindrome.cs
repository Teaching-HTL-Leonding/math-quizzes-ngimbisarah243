
int i = 0;
int j = 0;
int largestPalindrome = 0;

for (i = 100; i < 1000; i++)
{
    for (j = 100; j < 1000; j++)
    {
        int product = i * j;

        if (isPalindrome(product))
        {
            if (product > largestPalindrome)
            {
                largestPalindrome = product;
            }
        }
    }
}

Console.Write("The largest palindrome of the product of two 3-digit numbers is ");
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine(largestPalindrome);
Console.ResetColor();

bool isPalindrome(int product)
{
    int n = product;
    int rest = 0;
    int digit = 0;
    while (n > 0)
    {
        digit = n % 10;
        rest = rest * 10 + digit;
        n = n / 10;

        if (n == rest)
        {
            return true;
        }
    }
    return false;
}




