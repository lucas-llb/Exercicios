using System;

public static class Gigasecond
{
    public static DateTime Add(DateTime moment)
    {
        double giga = 1000000000;
        
        DateTime futuro;
        futuro = moment.AddSeconds(giga);
        return futuro;
    }
}