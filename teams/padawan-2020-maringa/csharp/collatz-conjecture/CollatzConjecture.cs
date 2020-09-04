using System;

public static class CollatzConjecture
{
    public static int Steps(int number)
    {
        int count = 0;
        int NewNumber = number;
        if (NewNumber > 0)
        {
            while (NewNumber != 1)
            {
                if (NewNumber % 2 == 0)
                {
                    NewNumber = NewNumber / 2;
                    count++;
                }
                else
                {
                    NewNumber = (3 * NewNumber) + 1;
                    count++;
                }
            }
        }
        else
        {
            throw new ArgumentOutOfRangeException();
        }
        return count;
    }
}