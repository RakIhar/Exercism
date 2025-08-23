public class PhoneNumber
{
    public static string Clean(string phoneNumber)
    {
        var res = new string(phoneNumber.Where(c => "0123456789".Contains(c)).ToArray());
        if (res.Length == 10)
        {
            if (res[0] >= '2' && res[3] >= '2')
            return res;
        }
        else if (res.Length == 11)
        {
            if (res[0] == '1' && res[1] >= '2' && res[4] >= '2')
                return res[1..^0];
            throw new ArgumentException();
        }
        throw new ArgumentException();
    }
}