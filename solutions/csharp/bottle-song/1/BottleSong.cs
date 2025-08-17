public static class BottleSong
{

    public static IEnumerable<string> Recite(int startBottles, int takeDown)
    {
        string[] numsLittle = ["no", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten"];
        string[] numsBig = ["No", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten"];
        List<string> res = new();
        for (int i = 0; i < takeDown; i++)
        {
            if (startBottles > 2)
            {
                res.Add($"{numsBig[startBottles]} green bottles hanging on the wall,");
                res.Add($"{numsBig[startBottles]} green bottles hanging on the wall,");
                res.Add("And if one green bottle should accidentally fall,");
                res.Add($"There'll be {numsLittle[--startBottles]} green bottles hanging on the wall.");
                res.Add("");
            }
            else if (startBottles == 2)
            {
                res.Add($"Two green bottles hanging on the wall,");
                res.Add($"Two green bottles hanging on the wall,");
                res.Add("And if one green bottle should accidentally fall,");
                res.Add($"There'll be one green bottle hanging on the wall.");
                --startBottles;
                res.Add("");
            }
            else if (startBottles == 1)
            {
                res.Add($"One green bottle hanging on the wall,");
                res.Add($"One green bottle hanging on the wall,");
                res.Add("And if one green bottle should accidentally fall,");
                res.Add($"There'll be no green bottles hanging on the wall.");
                --startBottles;
                res.Add("");
            }
            else
            {
                break;
            }
           
        }
        res.RemoveAt(res.Count - 1);
        return res;
    }
}