static class LogLine
{
    public static string Message(string logLine) => logLine.Remove(0, logLine.IndexOf(":") + 1).Trim();


    public static string LogLevel(string logLine)
    {
        var strings = logLine.Split();
        return strings[0].Trim([':', '[', ']']).ToLower();
    }

    // public static string Reformat(string logLine) => Message(logLine) + " (" + LogLevel(logLine) + ")";
    public static string Reformat(string logLine) => $"{Message(logLine)} ({LogLevel(logLine)})";
}
