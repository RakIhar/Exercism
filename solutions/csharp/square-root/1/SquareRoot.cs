public static class SquareRoot
{
    public static int Root(int number)
    {
        int i = 0;
        while (number > i * i)
        {
            i++;
        }
        return i;
    }
}
