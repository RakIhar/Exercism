public static class Sieve
{
    public static int[] Primes(int limit)
    {
        if (limit < 1) throw new ArgumentOutOfRangeException();
        bool[] primes = new bool[limit + 1];
        Array.Fill(primes, true);
        primes[0] = false;
        primes[1] = false;
        for (int i = 2; i <= limit; i++) 
        {
            if (!primes[i])
                continue;
            for (int nextMultiple = 2 * i; nextMultiple <= limit; nextMultiple += i)
                primes[nextMultiple] = false;
        }
        return primes.Select((value, i) => i).Where(i => primes[i]).ToArray();
    }
}