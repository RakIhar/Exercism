public class Queen
{
    public Queen(int row, int column)
    {
        Row = row;
        Column = column;
    }

    public int Row { get; }
    public int Column { get; }
}

public static class QueenAttack
{
    public static bool CanAttack(Queen white, Queen black)
        => ((white.Row - black.Row) == (white.Column - black.Column)) || ((white.Row - black.Row) == -(white.Column - black.Column)) || white.Row == black.Row || white.Column == black.Column;

    public static Queen Create(int row, int column)
        => row < 8 && row >= 0 && column < 8 && column >= 0 ? new Queen(row, column) : throw new ArgumentOutOfRangeException(); 
}