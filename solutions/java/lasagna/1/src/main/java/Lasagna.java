public class Lasagna {
    public int expectedMinutesInOven()
    {
        return 40;
    }

    public int remainingMinutesInOven(int time)
    {
        return expectedMinutesInOven() - time;
    }

    public int preparationTimeInMinutes(int layerCount)
    {
        return layerCount * 2;
    }

    public int totalTimeInMinutes(int layerCount, int time)
    {
        return time + preparationTimeInMinutes(layerCount);
    }
}
