class NeedForSpeed {
    private int speed;
    private int batteryCharge = 100;
    private int batteryDrain;
    private int distanceDriven = 0;

    NeedForSpeed(int speed, int batteryDrain) {
        this.speed = speed;
        this.batteryDrain = batteryDrain;
    }

    public boolean batteryDrained() {
        return batteryCharge < batteryDrain;
    }

    public int distanceDriven() {
        return distanceDriven;
    }

    public void drive() {
        if (batteryCharge >= batteryDrain) {
            batteryCharge -= batteryDrain;
            distanceDriven += speed;
        }
    }

    public static NeedForSpeed nitro() {
        return new NeedForSpeed(50, 4);
    }

    public boolean canFinishRace(int distance) {
        int possibleDrives = batteryCharge / batteryDrain;
        int maxDistance = possibleDrives * speed;

        return maxDistance >= distance;
    }
}

class RaceTrack {
    private final int distance;

    RaceTrack(int distance) {
        this.distance = distance;
    }

    public boolean canFinishRace(NeedForSpeed car) {
        return car.canFinishRace(distance);
    }
}
