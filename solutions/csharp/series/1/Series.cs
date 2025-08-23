public static class Series
{
    public static string[] Slices(string numbers, int sliceLength)
        => sliceLength > numbers.Length || sliceLength < 1 || numbers.Length == 0 ? throw new ArgumentException() : Enumerable.Range(0, numbers.Length - sliceLength + 1).Select((x, i) => numbers[i..(i +         sliceLength)]).ToArray();  
}