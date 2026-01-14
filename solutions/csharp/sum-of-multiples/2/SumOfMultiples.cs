public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
        => Enumerable.Range(1, max - 1).Where(x => multiples.Any(y => y > 0 && x % y == 0 )).Sum();
}