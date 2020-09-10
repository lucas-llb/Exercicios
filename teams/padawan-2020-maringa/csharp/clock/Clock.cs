using System;
using System.Diagnostics.CodeAnalysis;

public partial class Clock
{
    internal int Hora { get; }
    internal int Minutes { get; }
    public Clock(int hours, int minutes)
    {
        Hora = (hours + (minutes / 60)) % 24;
        Minutes = minutes % 60;

        if (Minutes < 0)
        {
            Hora--;
            Minutes = 60 + Minutes;
        }
        if (Hora < 0)
        {
            Hora = 24 + Hora;
        }
        
    }

    public Clock Add(int minutesToAdd)
    {

        var Relogio = new Clock(Hora, Minutes + minutesToAdd);
        return Relogio;
    }

    public Clock Subtract(int minutesToSubtract)
    {
        var Relogio = new Clock(Hora, Minutes - minutesToSubtract);
        return Relogio;
    }
    public override string ToString()
    {
        return $"{Hora:0#}:{Minutes:0#}";
    }
    public override bool Equals(object obj)
    {
        if (ReferenceEquals(this, obj))
        {
            return true;
        }

        return obj is Clock clock && Equals(clock);
    }
    public override int GetHashCode() => HashCode.Combine(Hora, Minutes);
}
   

