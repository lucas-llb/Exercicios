using System;

public class SpaceAge
{
    private double spaceage;
    public SpaceAge(int seconds)
    {
        spaceage = (double)seconds; 
    }

    public double OnEarth()
    {
        double days = 31557600;
        return spaceage / days;

    }

    public double OnMercury()
    {
        return spaceage / (0.2408467*31557600);
    }

    public double OnVenus()
    {
        return spaceage / (0.61519726*31557600);
    }

    public double OnMars()
    {
        return spaceage / (1.8808158*31557600);
    }

    public double OnJupiter()
    {
        return spaceage / (11.862615*31557600);
    }

    public double OnSaturn()
    {
        return spaceage / (29.447498*31557600);
    }

    public double OnUranus()
    {
        return spaceage / (84.016846*31557600);
    }

    public double OnNeptune()
    {
        return spaceage / (164.79132*31557600);
    }
}