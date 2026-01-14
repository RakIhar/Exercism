public class CarsAssemble {
    public double productionRatePerHour(int speed) {
        double res = speed * 221;
        if (speed == 0)
            res = 0;
        else if (speed > 4 && speed < 9)
            res *= 0.9;
        else if (speed == 9)
            res *= 0.8;
        else if (speed == 10)
            res *= 0.77;
        return res;
    }

    public int workingItemsPerMinute(int speed) {
        return (int) (productionRatePerHour(speed) / 60);
    }
}
