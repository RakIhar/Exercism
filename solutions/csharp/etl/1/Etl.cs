public static class Etl
{
    public static Dictionary<string, int> Transform(Dictionary<int, string[]> old)
        => old.SelectMany(item => item.Value.Select(str => KeyValuePair.Create(str.ToLower(), item.Key))).ToDictionary();

}