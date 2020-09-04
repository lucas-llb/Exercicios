using System;
using System.Collections.Generic;

public static class NucleotideCount
{
    public static IDictionary<char, int> Count(string sequence)
    {
        IDictionary<char, int> lista = new Dictionary<char, int>();
        int countA = 0;
        int countG = 0;
        int countT = 0;
        int countC = 0;
        for(int i=0; i<sequence.Length; i++)
        {
            if(sequence[i] == 'A')
            {
                countA ++;
            }
            else if (sequence[i] == 'G')
            {
                countG++;
            }
            else if (sequence[i] == 'T')
            {
                countT++;
            }
            else if (sequence[i] == 'C')
            {
                countC++;
            }
            else
            {
                throw new System.ArgumentException("Não existe essa sequencia.");
            }
        }
        lista.Add('A', countA);
        lista.Add('C', countC);
        lista.Add('G', countG);
        lista.Add('T', countT);

        return lista;

    }
}