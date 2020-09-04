using System;
using System.Collections.Generic;

public enum Plant
{
    Violets = 'V',
    Radishes = 'R',
    Clover = 'C',
    Grass = 'G'
}

public class KindergartenGarden
{
    public string Parte1 { get; set; }
    public string Parte2 { get; set; }
    public class Aluno
    {
        public string Nome { get; set; }
        public int pos1 { get; set; }
        public int pos2 { get; set; }
    }
    
    public KindergartenGarden(string diagram)
    {
        string[] aux = diagram.Split('\n');
        Parte1 = aux[0];
        Parte2 = aux[1];
    }

    public IEnumerable<Plant> Plants(string student)
    {
        var linha1 = new int[2];
        var linha2 = new int[2];
        var lista = new List<Plant>();
        for(int i=0; i<Parte1.Length; i++)
        {
           
        }
    }
}