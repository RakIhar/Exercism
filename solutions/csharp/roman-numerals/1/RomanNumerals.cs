using System.Text;public static class RomanNumeralExtension
{
    public static string ToRoman(this int value)
    {
        StringBuilder num = new("");
        int[] arr = new int[] { value / 1000, (value / 100) % 10, (value / 10) % 10, value % 10 };
        switch (arr[0])
        {
            case 1:
                num.Append("M");
                break;
            case 2:
                num.Append("MM");
                break;
            case 3:
                num.Append("MMM");
                break;
        }
        switch (arr[1])
        {
            case 1:
                num.Append("C");
                break;
            case 2:
                num.Append("CC");
                break;
            case 3:
                num.Append("CCC");
                break;
            case 4:
                num.Append("CD");
                break;
            case 5:
                num.Append("D");
                break;
            case 6:
                num.Append("DC");
                break;
            case 7:
                num.Append("DCC");
                break;
            case 8:
                num.Append("DCCC");
                break;
            case 9:
                num.Append("CM");
                break;
        }
        switch (arr[2])
        {
            case 1:
                num.Append("X");
                break;
            case 2:
                num.Append("XX");
                break;
            case 3:
                num.Append("XXX");
                break;
            case 4:
                num.Append("XL");
                break;
            case 5:
                num.Append("L");
                break;
            case 6:
                num.Append("LX");
                break;
            case 7:
                num.Append("LXX");
                break;
            case 8:
                num.Append("LXXX");
                break;
            case 9:
                num.Append("XC");
                break;
        }
        switch (arr[3])
        {
            case 1:
                num.Append("I");
                break;
            case 2:
                num.Append("II");
                break;
            case 3:
                num.Append("III");
                break;
            case 4:
                num.Append("IV");
                break;
            case 5:
                num.Append("V");
                break;
            case 6:
                num.Append("VI");
                break;
            case 7:
                num.Append("VII");
                break;
            case 8:
                num.Append("VIII");
                break;
            case 9:
                num.Append("IX");
                break;
        }
        return num.ToString();
    }
}