using System;
using System.Collections.Generic;

public static class Strain
{
    public static IEnumerable<T> Keep<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
    {
        var result = new List<T>();
        foreach(var item in collection)
        {
            var teste = predicate(item);
            if (teste)
            {
                result.Add(item);
            }
        }
       return result;
    }

    public static IEnumerable<T> Discard<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
    {
        var result = new List<T>();
        foreach (var item in collection)
        {
            var teste = predicate(item);
            if (!teste)
            {
                result.Add(item);
            }
        }
        return result;
    }
}