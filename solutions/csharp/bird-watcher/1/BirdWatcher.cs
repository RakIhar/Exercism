class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
        => [0, 2, 5, 3, 7, 8, 4];
    

    public int Today()
        => birdsPerDay[^1];

    public void IncrementTodaysCount()
        => birdsPerDay[^1] += 1;

    public bool HasDayWithoutBirds()
    {
        bool isCorrect = false;
        foreach (var item in birdsPerDay)
            if (item == 0)
                isCorrect = true;
        
        return isCorrect;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int res = 0;
        for(int i = 0; i < numberOfDays; i++)
            res += birdsPerDay[i];
        return res;
    }

    public int BusyDays()
    {
        int daysCount = 0;
        foreach (var item in birdsPerDay)
            if (item >= 5)
                ++daysCount;
        return daysCount;
    }
}
