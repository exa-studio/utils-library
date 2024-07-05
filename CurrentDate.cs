namespace utils_library;

public static class CurrentDate
{
    public static DateTime GetDateTime() => DateTime.Now;
    public static DateTime GetDateTime2() => DateTime.Now;
    public static DateTime GetDateTimeAndOneHour() => DateTime.Now.AddHours(1);
}