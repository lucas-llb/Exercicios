using System;

public static class ResistorColor
{
    public static int ColorCode(string color)
    {
        int cor = 0;
        if(color == "black")
        {
            cor = 0;
        }
        if(color == "brown")
        {
            cor = 1;
        }
        if(color == "red")
        {
            cor = 2;
        }
        if(color == "orange")
        {
            cor = 3;
        }
        if(color == "yellow")
        {
            cor = 4;
        }
        if(color == "green")
        {
            cor = 5;
        }
        if(color == "blue")
        {
            cor = 6;
        }
        if(color == "violet")
        {
            cor = 7;
        }
        if(color == "grey")
        {
            cor = 8;
        }
        if(color == "white")
        {
            cor = 9;
        }
        return cor;
    }

    public static string[] Colors()
    {
        string[] cores = new string[10];
        cores[0] = "black";
        cores[1] = "brown";
        cores[2] = "red";
        cores[3] = "orange";
        cores[4] = "yellow";
        cores[5] = "green";
        cores[6] = "blue";
        cores[7] = "violet";
        cores[8] = "grey";
        cores[9] = "white";

        return cores;
    }
}