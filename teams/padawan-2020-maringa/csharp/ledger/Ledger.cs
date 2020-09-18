using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

public class LedgerEntry
{
    public LedgerEntry(DateTime date, string desc, decimal chg)
    {
        Date = date;
        Desc = desc;
        Chg = chg;
    }

    public DateTime Date { get; }
    public string Desc { get; }
    public decimal Chg { get; }
}

public static class Ledger
{
    private const string locNL = "nl-NL";
    private const string LOCUS = "en-US";
    private const string MonthDay = "MM/dd/yyyy";
    private const string DayMonth = "dd/MM/yyyy";

    public static LedgerEntry CreateEntry(string date, string desc, int chng)
    {
        return new LedgerEntry(DateTime.Parse(date, CultureInfo.InvariantCulture), desc, chng / 100.0m);
    }

    private static CultureInfo CreateCulture(string cur, string loc)
    {

        var cc = new CultureInfo(locNL);
        cc.
        string curSymb = null;
        int curNeg = 0;
        string datPat = null;

        if ((cur != "USD" && cur != "EUR") || (loc != locNL && loc != LOCUS))
        {
            throw new ArgumentException("Invalid currency");
        }
        else
        {
            if (cur == "USD")
            {
                curSymb = "$";
                if (loc == LOCUS)
                    datPat = MonthDay;
                else if (loc == locNL)
                {
                    curNeg = 12;
                    datPat = DayMonth;
                }
            }
            if (cur == "EUR")
            {
                curSymb = "€";
                if (loc == LOCUS)
                    datPat = MonthDay;

                else if (loc == locNL)
                {
                    curNeg = 12;
                    datPat = DayMonth;
                }
            }
        }

        var culture = new CultureInfo(loc);
        culture.NumberFormat.CurrencySymbol = curSymb;
        culture.NumberFormat.CurrencyNegativePattern = curNeg;
        culture.DateTimeFormat.ShortDatePattern = datPat;
        return culture;
    }

    private static string PrintHead(string loc)
    {
        if (loc == LOCUS)
           return "Date       | Description               | Change       ";
        else
        {
            if (loc == locNL)
            {
                return "Datum      | Omschrijving              | Verandering  ";
            }
            else
            {
                throw new ArgumentException("Invalid locale");
            }
        }
    }

    private static string Date(IFormatProvider culture, DateTime date) => date.ToString("d", culture);

    private static string Description(string desc)
    {
        if (desc.Length > 25)
        {
            var trunc = desc.Substring(0, 22);
            trunc += "...";
            return trunc;
        }
        return desc;
    }

    private static string Change(IFormatProvider culture, decimal cgh)
    {
        return cgh < 0.0m ? cgh.ToString("C", culture) : cgh.ToString("C", culture) + " ";
    }

    private static string PrintEntry(IFormatProvider culture, LedgerEntry entry)
    {
        var date = Date(culture, entry.Date);
        var description = Description(entry.Desc);
        var change = Change(culture, entry.Chg);
        var formatted = date + " | " + string.Format("{0,-25}", description) + " | " + string.Format("{0,13}", change);
        return formatted;
    }


    private static IEnumerable<LedgerEntry> sort(LedgerEntry[] entries)
    {
        var neg = entries.Where(e => e.Chg < 0).OrderBy(x => x.Date).ThenBy(x=> x.Desc).ThenBy(x=> x.Chg);
        var post = entries.Where(e => e.Chg >= 0).OrderBy(x => x.Date).ThenBy(x=> x.Desc).ThenBy(x=> x.Chg);

        var result = new List<LedgerEntry>();
        result.AddRange(neg);
        result.AddRange(post);

        return result;
    }

    public static string Format(string currency, string locale, LedgerEntry[] entries)
    {
        var formatted = PrintHead(locale);

        var culture = CreateCulture(currency, locale);

        if (entries.Length > 0)
        {
            var entriesForOutput = sort(entries);

            for (var i = 0; i < entriesForOutput.Count(); i++)
            {
                formatted += "\n" + PrintEntry(culture, entriesForOutput.Skip(i).First());
            }
        }

        return formatted;
    }
}
