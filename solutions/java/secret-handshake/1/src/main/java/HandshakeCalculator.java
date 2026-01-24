import java.util.ArrayList;
import java.util.List;

class HandshakeCalculator {

    List<Signal> calculateHandshake(int number) {
        List<Signal> list = new ArrayList<>();
        if ((number & 1) == 1)
            list.add(Signal.WINK);
        if ((number & 2) == 2)
            list.add(Signal.DOUBLE_BLINK);
        if ((number & 4) == 4)
            list.add(Signal.CLOSE_YOUR_EYES);
        if ((number & 8) == 8)
            list.add(Signal.JUMP);
        if ((number & 16) == 16)
            return list.reversed();

        return list;
    }

}
