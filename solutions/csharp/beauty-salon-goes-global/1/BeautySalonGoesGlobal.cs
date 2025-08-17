using System.Globalization;

public enum Location
{
    NewYork,
    London,
    Paris
}

public enum AlertLevel
{
    Early,
    Standard,
    Late
}

public static class Appointment
{
    public static DateTime ShowLocalTime(DateTime dtUtc)
        => dtUtc.ToLocalTime();


    public static DateTime Schedule(string appointmentDateDescription, Location location)
    {
        DateTime dt = DateTime.Parse(appointmentDateDescription);
        //- New York - Eastern Standard Time
        //-London - GMT Standard Time
        //-Paris - W.Europe Standard Time
        String str = location switch
        {
            Location.London => "GMT Standard Time",
            Location.NewYork => "Eastern Standard Time",
            Location.Paris => "Romance Standard Time",
            _ => TimeZoneInfo.Utc.Id
        };
        var tz = TimeZoneInfo.FindSystemTimeZoneById(str);
        return TimeZoneInfo.ConvertTimeToUtc(dt, tz);
    }

    public static DateTime GetAlertTime(DateTime appointment, AlertLevel alertLevel)
        => alertLevel switch
        {
            AlertLevel.Early => appointment.AddDays(-1),
            AlertLevel.Standard => appointment.AddHours(-1).AddMinutes(-45),
            AlertLevel.Late => appointment.AddMinutes(-30),
            _ => DateTime.Today
        };

    public static bool HasDaylightSavingChanged(DateTime dt, Location location)
    {
        var tz = TimeZoneInfo.FindSystemTimeZoneById(location switch
        {
            Location.London => "GMT Standard Time",
            Location.NewYork => "Eastern Standard Time",
            Location.Paris => "Romance Standard Time",
            _ => TimeZoneInfo.Utc.Id
        });
        return tz.IsDaylightSavingTime(dt) != tz.IsDaylightSavingTime(dt.AddDays(-7));
    }

    public static DateTime NormalizeDateTime(string dtStr, Location location)
    
        //CultureInfo cultureInfo = new(location switch
        //{
        //    Location.London => "en-GB",
        //    Location.NewYork => "en-US",
        //    Location.Paris => "fr-FR",
        //    _ => ""
        //});
        => DateTime.TryParse
            (dtStr, new CultureInfo 
                (location switch
                {
                    Location.London => "en-GB",
                    Location.NewYork => "en-US",
                    Location.Paris => "fr-FR",
                    _ => ""
                }
                ), out DateTime newDt
            ) ? newDt : new DateTime(1,1,1);
    
}
