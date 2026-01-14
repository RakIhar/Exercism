public static class CollatzConjecture
{
    public static int Steps(int number)
    {
        if (number < 1) throw new ArgumentOutOfRangeException();
        int countOfSteps = 0;
        while(number != 1)
        {
            number = number % 2 == 0 ? number / 2 : number * 3 + 1;
            countOfSteps++;    
        }
        return countOfSteps;
    }
}