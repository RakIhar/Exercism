public class Player
{
    public int RollDie()
    {
        Random r = new();
        return r.Next(1, 18);
    }

    public double GenerateSpellStrength()
    {
        Random r = new();
        return 100 * r.NextDouble();
    }
}
