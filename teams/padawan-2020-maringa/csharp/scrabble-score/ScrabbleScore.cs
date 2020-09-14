using System;
using System.Text.RegularExpressions;
public static class ScrabbleScore
{
    public static int Score(string input)
    {

        int points = 0;
        input = input.ToUpper();
        points += (Regex.Matches(input, @"[|A|E|I|O|U|L|N|R|S|T|]").Count) * 1;
        points += (Regex.Matches(input, @"[|D|G|]").Count) * 2;
        points += (Regex.Matches(input, @"[|B|C|M|P|]").Count) * 3;
        points += (Regex.Matches(input, @"[|F|H|V|W|Y|]").Count) * 4;
        points += (Regex.Matches(input, @"[|K|]").Count) * 5;
        points += (Regex.Matches(input, @"[|J|X|]").Count) * 8;
        points += (Regex.Matches(input, @"[|Q|Z|]").Count) * 10;

        return points;


    }
}