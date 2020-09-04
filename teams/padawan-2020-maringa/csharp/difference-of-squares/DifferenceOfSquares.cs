using System;

public static class DifferenceOfSquares
{
    public static int CalculateSquareOfSum(int max)
    {
        int soma = 0;
        for(int i=1; i<=max; i++)
        {
            soma += i;
        }
        soma = (int)Math.Pow(soma, 2);
        return soma;
    }

    public static int CalculateSumOfSquares(int max)
    {
        int soma = 0;
        for(int i=1; i<=max; i++)
        {
            soma += (int)Math.Pow(i, 2);
        }
        return soma;
    }

    public static int CalculateDifferenceOfSquares(int max)
    {
        int Diferenca = CalculateSquareOfSum(max) - CalculateSumOfSquares(max);
        return Diferenca;
    }
}