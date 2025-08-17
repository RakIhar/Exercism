using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using System.Diagnostics.Metrics;

public class RemoteControlCar
{
    private int batteryPercentage = 100;
    private int distanceDrivenInMeters = 0;
    private string[] sponsors = new string[0];
    private int latestSerialNum = 0;

    public void Drive()
    {
        if (batteryPercentage > 0)
        {
            batteryPercentage -= 10;
            distanceDrivenInMeters += 2;
        }
    }

    public void SetSponsors(params string[] sponsors) => this.sponsors = sponsors;


    public string DisplaySponsor(int sponsorNum) => sponsors[sponsorNum];

    public bool GetTelemetryData(ref int serialNum,
        out int batteryPercentage, out int distanceDrivenInMeters)
    {
        if (serialNum > latestSerialNum)
        {
            batteryPercentage =  this.batteryPercentage;
            distanceDrivenInMeters =  this.distanceDrivenInMeters;
            latestSerialNum = serialNum;
            return true;
        }
        else
        {
            batteryPercentage = -1;
            distanceDrivenInMeters = -1;
            serialNum = latestSerialNum;
            return false;
        } 
    }

    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
    }
}

public class TelemetryClient
{
    private RemoteControlCar car;

    public TelemetryClient(RemoteControlCar car)
    {
        this.car = car;
    }

    public string GetBatteryUsagePerMeter(int serialNum)
    {
        bool isCorrect = car.GetTelemetryData(ref serialNum, out int battery, out int distance);
        if (!isCorrect || distance == 0)
            return "no data";
        return $"usage-per-meter={(100 - battery) / distance}";
        //This will call `RemoteControlCar.GetTelemetryData()`. 
        //If `GetTelemetryData()` returns `false` or the car has not been driven, then this routine should return "no data".
        //If `GetTelemetryData()` returns `true` then a message in the following form should be returned "usage-per-meter=BATTERY-USAGE-PER-METER".
        //Where the calculation is (100 - current battery percentage) divided by the distance driven in meters so far.
    }
}
