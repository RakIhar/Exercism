public static class TwoFer
{
    public static string Speak(string someone = "")
        => someone == "" ? "One for you, one for me." : $"One for {someone}, one for me.";
}
