public class JedliksToyCar {
    int distanceDriven = 0;
    int batteryPercentage = 100;

    public static JedliksToyCar buy() {
        return new JedliksToyCar();
    }

    public String distanceDisplay() {
        return String.format("Driven %d meters", distanceDriven);
    }

    public String batteryDisplay() {
        if (batteryPercentage == 0)
            return "Battery empty";
        return String.format("Battery at %d%%", batteryPercentage);
    }

    public void drive() {
        if (batteryPercentage > 0)
        {
            batteryPercentage--;
            distanceDriven += 20;
        }
    }
}
