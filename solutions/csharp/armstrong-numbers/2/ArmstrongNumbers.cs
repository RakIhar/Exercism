public static class ArmstrongNumbers
{
    public static bool IsArmstrongNumber(int number)
        => (from digit in number.ToString()
            let power = number.ToString().Length
            select (int)Math.Pow(char.GetNumericValue(digit), power))
            .Sum() == number;
}