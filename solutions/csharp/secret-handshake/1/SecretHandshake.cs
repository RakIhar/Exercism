public static class SecretHandshake
{
    public static string[] Commands(int commandValue)
    {
        LinkedList<string> coms = new();
        if (commandValue < 0 || commandValue > 31) throw new ArgumentOutOfRangeException();
        if (commandValue % 2 == 1)
            coms.AddLast("wink");
        commandValue /= 2;
        if (commandValue % 2 == 1)
            coms.AddLast("double blink");
        commandValue /= 2;
        if (commandValue % 2 == 1)
            coms.AddLast("close your eyes");
        commandValue /= 2;
        if (commandValue % 2 == 1)
            coms.AddLast("jump");
        commandValue /= 2;
        return commandValue % 2 == 1 ? coms.Reverse().ToArray() : coms.ToArray();
    }
}
