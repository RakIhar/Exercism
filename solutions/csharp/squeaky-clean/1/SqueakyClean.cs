using System.Text;
using System.Text.Unicode;
public static class Identifier
{
    public static string Clean(string identifier)
    {
        StringBuilder strB = new(identifier);
        strB.Replace(' ', '_');
        strB.Replace("\0", "CTRL");
        for(int i = 1; i < strB.Length; i++)
        {
            if (strB[i - 1] == '-')
                strB[i] = Char.ToUpper(strB[i]);
        }
        

        UnicodeRange greek = UnicodeRanges.GreekandCoptic;
        UnicodeRange greekExtended = UnicodeRanges.GreekExtended;
        bool isGreek(char c)
        {
            return (c >= greek.FirstCodePoint && c <= greek.FirstCodePoint + greek.Length) 
                || (c >= greekExtended.FirstCodePoint && c <= greekExtended.FirstCodePoint + greekExtended.Length);
        }
        for (int i = 0; i < strB.Length; i++)
        {
            Char c = strB[i];
            if (!(Char.IsLetter(c) || c == '_') || (isGreek(c) && Char.IsLower(c)))           
                strB[i] = '-';
        }
        strB.Replace("-", "");
        return strB.ToString();
    }
}
