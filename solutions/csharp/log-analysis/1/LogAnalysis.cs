public static class LogAnalysis 
{
    public static string SubstringAfter(this string str, string after) 
        => str.Remove(0, str.IndexOf(after) + after.Length);
    // TODO: define the 'SubstringBetween()' extension method on the `string` type
    public static string SubstringBetween(this string str, string after, string before) 
    {
        str = str.SubstringAfter(after);
        return str.Remove(str.IndexOf(before), str.Length - str.IndexOf(before));
    }
    // TODO: define the 'Message()' extension method on the `string` type
    public static string Message(this string str) => str.SubstringAfter(": ");
    // TODO: define the 'LogLevel()' extension method on the `string` type
    public static string LogLevel(this string str) => str.SubstringBetween("[", "]");
}