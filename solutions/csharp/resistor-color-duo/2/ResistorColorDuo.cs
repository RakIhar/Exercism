public static class ResistorColorDuo
{
    public static int ColorCode(string color)
        => color switch
        {
            "black" => 0,
            "brown" => 1,
            "red" => 2,
            "orange" => 3,
            "yellow" => 4,
            "green" => 5,
            "blue" => 6,
            "violet" => 7,
            "grey" => 8,
            "white" => 9,
            _ => -1
        };
    public static int Value(string[] colors)
        => colors.Length switch
        {
            0 => -1,
            1 => ColorCode(colors[0]),
            _ => ColorCode(colors[0]) * 10 + ColorCode(colors[1])  
        };
}
