public static class PlayAnalyzer
{
    public static string AnalyzeOnField(int shirtNum)
        => shirtNum switch
        {
            1 => "goalie",
            2 => "left back",
            3 or 4 => "center back",
            5 => "right back",
            6 or 7 or 8 => "midfielder",
            9 => "left wing",
            10 => "striker",
            11 => "right wing",
            _ => "UNKNOWN"
        };

    public static string AnalyzeOffField(object report)
    {
        switch (report)
        {
            case int intNum:
                return $"There are {intNum} supporters at the match.";
            case string str:
                return str;
            case Foul foul:
                return foul.GetDescription();
            case Injury injury:
                return $"Oh no! {injury.GetDescription()} Medics are on the field.";
            case Incident incident:
                return incident.GetDescription();
            case Manager manager when manager.Club is null:
                return manager.Name;
            case Manager manager:
                return $"{manager.Name} ({manager.Club})";
            default:
                return "";
        }
    }
}
