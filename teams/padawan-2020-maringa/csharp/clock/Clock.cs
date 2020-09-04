using System;

public class Clock
{
    public int Hora { get; set; }
    public int Minutes { get; set; }
    public Clock(int hours, int minutes)
    {
        Hora = hours;
        Minutes = minutes;
    }

    public Clock Add(int minutesToAdd)
    {

        var Relogio = new Clock(Hora, Minutes + minutesToAdd);
        return Relogio;
    }

    public Clock Subtract(int minutesToSubtract)
    {
        throw new NotImplementedException("You need to implement this function.");
    }
}
