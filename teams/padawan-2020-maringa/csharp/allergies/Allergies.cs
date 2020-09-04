using System;
using System.Collections.Generic;
using System.Linq;

public enum Allergen
{
    Eggs=1,
    Peanuts=2,
    Shellfish=4,
    Strawberries=8,
    Tomatoes=16,
    Chocolate=32,
    Pollen=64,
    Cats=128
}

public class Allergies
{
    public int score { get; set; }
    public Allergen[] Alergias { get; set; }

    public Allergies(int mask)
    {
        score = mask;
    }

    public bool IsAllergicTo(Allergen allergen)
    {
        return (score & allergen.GetHashCode()) != 0;
    }

    public Allergen[] List()
    {
        if (score == 0)
        {
            return new Allergen[0];
        }
        List<int> lista = new List<int>();
        // var alergens = new Allergen[8];
        List<Allergen> allergens = new List<Allergen>();

        foreach (var item in Enum.GetValues(typeof(Allergen)))
        {
            if (IsAllergicTo((Allergen)item))
            {
                lista.Add(item.GetHashCode());
                allergens.Add((Allergen)item);
            }
        }

        // var Alergias = new Allergen[8];
        //for (int i = 0; i < lista.Count; i++)
        //{
        //    Alergias[i] = (Allergen)lista[i];
        //}

        return allergens.ToArray();
    }
}