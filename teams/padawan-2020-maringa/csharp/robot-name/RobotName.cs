using System;
using System.Collections.Generic;

public class Robot
{
    public string Name { get; set; }
    private static readonly List<string> RobotNames = new List<string>();
    private readonly Random valores= new Random();
    public Robot()
    {
        NomeMaker();
    }
    public void NomeMaker()
    {
        Name = "";
        bool verificaNome = false;
        do
        {
            for (int i = 0; i < 5; i++)
            {
                if (i < 2)
                {
                    Name += Convert.ToChar(valores.Next(65, 90));
                }
                else
                {
                    Name += Convert.ToChar(valores.Next(48, 57));
                }
               
            }
            if (RobotNames.Contains(Name))
            {
                verificaNome = true;
            }
            else
            {
                verificaNome = false;
            }
        } while (verificaNome);
        RobotNames.Add(Name);
     
    }

    public void Reset()
    {
        RobotNames.Remove(Name);
        NomeMaker();
    }
}