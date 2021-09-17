Console.WriteLine("Biggest prime factor");

long n = 600851475143;


static bool isPrime(long n)
{
    if (n <= 3)
    {
        return n >= 2;
    }
    if (n % 2 == 0 || n % 3 == 0)
    {
        return false;
    }
    for (int i = 5; i <= n + 1; i += 6)
    {
        if (n % i == 0 || n % (i + 2) == 0)
        {
            return false;
        }
    }

    return true;
}