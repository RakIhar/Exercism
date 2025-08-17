public static class DifferenceOfSquares
{
    public static int CalculateSquareOfSum(int max)
    {
        var res = 0;
        for (int i = 1; i <= max; i++)
        {
            res += i;
        }
        return res * res;
    }

    public static int CalculateSumOfSquares(int max)
    {
        var res = 0;
        for (int i = 1; i <= max; i++)
        {
            res += i*i;
        }
        return res;
    }

    public static int CalculateDifferenceOfSquares(int max)
        => CalculateSquareOfSum(max) - CalculateSumOfSquares(max);
    
}