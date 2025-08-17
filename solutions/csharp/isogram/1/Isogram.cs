public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        HashSet<Char> chars = new();

        foreach (var c in word)
        {
            var ch = Char.ToLower(c);
            if (ch == ' ' || ch == '-') continue;
            if (chars.Contains(ch)) return false;
            chars.Add(ch);
        }

        return true;
    }
}
