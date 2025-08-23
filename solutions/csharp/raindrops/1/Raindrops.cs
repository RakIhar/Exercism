using System.Text;public static class Raindrops
{
    public static string Convert(int number)
    {
        StringBuilder res = new();
        if (number % 3 == 0) res.Append("Pling");
        if (number % 5 == 0) res.Append("Plang");
        if (number % 7 == 0) res.Append("Plong");
        return res.Length == 0 ? number.ToString() : res.ToString();
    }
}