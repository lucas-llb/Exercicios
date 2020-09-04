using System;
using System.Collections.Generic;
using System.Linq;

public enum Classification
{
    Perfect,
    Abundant,
    Deficient
}

public static class PerfectNumbers
{
    public static Classification Classify(int number)
    {
        if (number > 0)
        {
            var divisores = new List<double>();
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    divisores.Add(i);
                }
            }
            var soma = divisores.Sum();
            if (soma < number)
            {
                return Classification.Deficient;
            }
            if (soma > number)
            {
                return Classification.Abundant;
            }
            else
            {
                return Classification.Perfect;
            }
        }
        else
        {
            throw new ArgumentOutOfRangeException();
        }
    }
}
