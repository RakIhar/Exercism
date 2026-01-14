public static class ParallelLetterFrequency
{
    public static Dictionary<char, int> Calculate(IEnumerable<string> texts)
        => texts
        .AsParallel()
        .SelectMany(txt => txt.ToLower().ToArray())
        .Where(ch => char.IsLetter(ch))
        .GroupBy(ch => ch).Select(gr => KeyValuePair.Create(gr.Key, gr.Count()))
        .ToDictionary();
}