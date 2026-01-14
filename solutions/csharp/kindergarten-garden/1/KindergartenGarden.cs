public enum Plant
{
    Violets,
    Radishes,
    Clover,
    Grass
}

public class KindergartenGarden
{
    List<string> _kids = ["Alice", "Bob", "Charlie", "David", "Eve", "Fred", "Ginny", "Harriet", "Ileana", "Joseph", "Kincaid", "Larry"];
    string _diagram;
    const int numberOfPlants = 12 * 2 + 12 * 2;
    public KindergartenGarden(string diagram)
    {
        if (diagram.Length-1 > numberOfPlants || (diagram.Length-1) % 4 != 0 || diagram.Except("GCRV\n").Any())
            throw new ArgumentException();
        _diagram = diagram;
    }


    public IEnumerable<Plant> Plants(string student)
    {
        if (!_kids.Contains(student))
            throw new ArgumentException();
        int i = _kids.FindIndex(x => x == student);
        if (i > (_diagram.Length-1) / 4)
            throw new ArgumentOutOfRangeException();
        int secondRowShift = (_diagram.Length-1) / 2 + 1;
        string res = _diagram[(i * 2)..(i * 2 + 2)] + _diagram[(i * 2 + secondRowShift)..(i * 2 + 2 + secondRowShift)];
        foreach(char c in res)
        {
            yield return c switch
            {
                'G' => Plant.Grass,
                'R' => Plant.Radishes,
                'C' => Plant.Clover,
                'V' => Plant.Violets,
                _ => throw new ArgumentOutOfRangeException()
            };
        }
    }
}