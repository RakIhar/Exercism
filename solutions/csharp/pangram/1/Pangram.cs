public static class Pangram
{
    public static bool IsPangram(string input)
    =>input.ToLower().Intersect("abcdefghijklmnopqrstuvwxyz").Count() == "abcdefghijklmnopqrstuvwxyz".Count();
}
