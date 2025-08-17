public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {
        HashSet<int> set = new();

        void addAllMultiples(int num)
        {
            if (num < 1) return;
            int prev = num;
            while (prev < max)
            {
                set.Add(prev);
                prev += num;
            }
        }
        foreach(var item in multiples) 
        {
            addAllMultiples(item);
        }

        return set.Sum();
    }
}