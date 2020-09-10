using System;
using System.Text.RegularExpressions;

public class PhoneNumber
{
    public static string Clean(string phoneNumber)
    {
        //string pattern = "/ ^([-][1]) ? ([(][2 - 9][0 - 9]{ 2}[)])[. | -][2 - 9][0 - 9]{ 2}[. | -][0 - 9]{ 4}$/";
        string patternValidacao = @"^(\+?1)?\D*\(?([2-9][0-9]{2})\)?\D*([2-9][0-9]{2})\D*([0-9]{4})\D*$";
        var regraValidacao = new Regex(patternValidacao);
        if (!regraValidacao.IsMatch(phoneNumber))
        {
            throw new ArgumentException();
        }
        var pralimpar = regraValidacao.Match(phoneNumber);
        var limpo = pralimpar.Groups[2].Value + pralimpar.Groups[3].Value + pralimpar.Groups[4].Value;
        return limpo;
    }
}