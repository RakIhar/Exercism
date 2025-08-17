using System.Text;
public class Robot
{
    private static HashSet<string> _nameSet = new();
    private string _name = "";
    public string Name { get => _name == "" ? _randomizeName() : _name; private set => _name = value; }

    const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    const string digits = "0123456789";
    private string _randomizeName()
    {
        StringBuilder res = new("AA000");
        Random random = new();
        do
        {
            res[0] = chars[random.Next(chars.Length)];
            res[1] = chars[random.Next(chars.Length)];
            res[2] = digits[random.Next(digits.Length)];
            res[3] = digits[random.Next(digits.Length)];
            res[4] = digits[random.Next(digits.Length)];
        }
        while (!_nameSet.Add(res.ToString()));
        _name = res.ToString();
        return res.ToString();

    }
    public void Reset()
    {
        if (_name != "")
        {
            _nameSet.Remove(_name);
            _name = "";
        }

    }
}