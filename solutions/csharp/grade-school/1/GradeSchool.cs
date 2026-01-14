public class GradeSchool
{
    private List<(string, int)> _students = new();

    public bool Add(string student, int grade)
    { 
        if (_students.Where(st => st.Item1 == student).Any())
            return false;
        
        _students.Add((student, grade));
        return true;
    }

    public IEnumerable<string> Roster()
        => _students.OrderBy(x => x.Item2).ThenBy(x => x.Item1).Select(x => x.Item1);

    public IEnumerable<string> Grade(int grade)
        => _students.Where(student => student.Item2 == grade).Select(student => student.Item1).OrderBy(x => x);
}