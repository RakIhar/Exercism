public enum Classification
{
    Perfect,
    Abundant,
    Deficient
}

public static class PerfectNumbers
{
    public static Classification Classify(int number)
    {
        if (number < 1) throw new ArgumentOutOfRangeException();
        if (number == 1) return Classification.Deficient;
        int res = Enumerable.Range(1, number / 2).Where(i => number % i == 0).Sum();
        return number == res ? Classification.Perfect : (number < res ? Classification.Abundant : Classification.Deficient);
    }
}
