public class SquareRoot {
    public int squareRoot(int radicand) {
        int i = 0;
        while(i * i < radicand)
            i++;
        return i;
    }
}
