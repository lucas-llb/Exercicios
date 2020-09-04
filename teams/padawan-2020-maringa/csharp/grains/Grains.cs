using System;

public static class Grains
{
    public static ulong Square(int n)
    {
        if (n > 0 && n <= 64)
        {
            var numero = Math.Pow(2, (n - 1));
            return (ulong)numero;
        }
        else
        {
            throw new ArgumentOutOfRangeException();
        }
    }

    public static ulong Total()
    {
        ulong soma = 0;
        ulong numero;
        for(int i =0; i<64; i++)
        {
            numero = (ulong)Math.Pow(2, i);
            soma += numero;
        }
        return (ulong)soma;
    }
}