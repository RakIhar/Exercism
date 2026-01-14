public static class ArmstrongNumbers
{
    public static bool IsArmstrongNumber(int number)
    {
        string numStr = number.ToString();
        int power = numStr.Length;
        int res = 0;
        int powerOfTen = 1;
        for (int i = 0; i < power; i++)
        {
            int partialRes = number / powerOfTen % 10;
            int accumulator = partialRes;
            for (int y = 1; y < power; y++)
                accumulator *= partialRes;
            res += accumulator;
            powerOfTen *= 10;
        }
        return res == number;
    }
    //154 != 1^3 + 5^3 + 4^3 = 1 + 125 + 64 = 190
}