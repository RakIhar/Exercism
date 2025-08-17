static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        if (id is not null && department is not null)
        {
            return $"[{id}] - {name} - {department.ToUpper()}";
        } 
        else if (id is null && department is null) 
        {
            return $"{name} - OWNER";
        } 
        else if (id is null)
        {
            return $"{name} - {department.ToUpper()}";
        } 
        else
        {
            return $"[{id}] - {name} - OWNER";
        }
        throw new NotImplementedException("Please implement the (static) Badge.Print() method");
    }
}
