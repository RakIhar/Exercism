public class ExperimentalRemoteControlCar implements RemoteControlCar
{
    private int distanceDriven = 0;


    public void drive() {
        distanceDriven += 20;
    }

    public int getDistanceTravelled() {
        return distanceDriven;
    }
}
