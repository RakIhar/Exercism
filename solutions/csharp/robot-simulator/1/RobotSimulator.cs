public enum Direction
{
    North,
    East,
    South,
    West
}

public class RobotSimulator
{
    private int _x, _y;
    private Direction _direction;
    public RobotSimulator(Direction direction, int x, int y)
    {
        _direction = direction;
        _x = x;
        _y = y;
    }

    public Direction Direction
    {
        get => _direction;
    }

    public int X
    {
        get => _x;
    }

    public int Y
    {
        get => _y;
    }

    private void changeDirection(char c)
    {
        switch (c)
        {
            case 'R':
                _direction = (int)_direction == 3 ? Direction.North : (Direction)((int)_direction + 1);
                break;
            case 'L':
                _direction = (int)_direction == 0 ? Direction.West : (Direction)((int)_direction - 1);
                break;
            case 'A':
                moveByDirection();
                break;
            default:
                throw new ArgumentException();
        }
    }

    private void moveByDirection()
    {
        switch (_direction)
        {
            case Direction.North:
                _y++;
                break;
            case Direction.East:
                _x++;
                break;
            case Direction.South:
                _y--;
                break;
            case Direction.West:
                _x--;
                break;
        }
    }

    public void Move(string instructions)
    {
        foreach (char c in instructions)
            changeDirection(c);
    }
}