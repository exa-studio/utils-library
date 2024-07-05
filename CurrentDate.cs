namespace utils_library;

public static class CurrentDate
{
    public static DateTime GetDateTime() => DateTime.Now;
    public static DateTime GetDateTimeAndOneHour() => DateTime.Now.AddHours(2);
}