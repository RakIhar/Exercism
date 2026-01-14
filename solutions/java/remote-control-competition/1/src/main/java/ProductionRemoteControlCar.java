class ProductionRemoteControlCar implements RemoteControlCar, Comparable<ProductionRemoteControlCar> {

    private int distanceDriven = 0;
    private int numberOfVictories = 0;

    public void drive() {
        distanceDriven += 10;
    }

    public int getDistanceTravelled() {
        return distanceDriven;
    }

    public int getNumberOfVictories() {
        return numberOfVictories;
    }

    public void setNumberOfVictories(int numberOfVictories) {
        this.numberOfVictories = numberOfVictories;
    }

    @Override
    public int compareTo(ProductionRemoteControlCar o) {
        return Integer.compare(o.numberOfVictories, numberOfVictories);
    }
}