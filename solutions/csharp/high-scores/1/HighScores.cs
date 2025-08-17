public class HighScores
{
    private List<int> list; 
    public HighScores(List<int> list)
        => this.list = list;
    

    public List<int> Scores()
        => list.Distinct().ToList();

    public int Latest()
        => list[^1];
    

    public int PersonalBest()
        => list.Max();

    public List<int> PersonalTopThree()
        => list.OrderDescending().Take(3).ToList();
}