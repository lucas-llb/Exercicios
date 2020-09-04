using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
public class DndCharacter
{
    public int Strength { get; set; }
    public int Dexterity { get; set; }
    public int Constitution { get; set; }
    public int Intelligence { get; set; }
    public int Wisdom { get; set; }
    public int Charisma { get; set; }
    public int Hitpoints { get; set; }

    public static int Modifier(int score)
    {
        int modificador;
        modificador = Convert.ToInt32(Math.Floor(((double)score - 10.0) / 2.0));
        //int modRound = Convert.ToInt32(Math.Round(modificador, 2, MidpointRounding.AwayFromZero));
        return modificador;
    }

    public static int Ability() 
    {
        return Dados();
    }

    public static DndCharacter Generate()
    {
        var Personagem = new DndCharacter()
        {
            Strength = Ability(),
            Wisdom = Ability(),
            Constitution = Ability(),
            Charisma = Ability(),
            Dexterity = Ability(),
            Intelligence = Ability(),

        };
        Personagem.Hitpoints = (10 + Modifier(Personagem.Constitution));
        return Personagem;
    }
    public static int Dados()
    {
        Random dice = new Random();
        var lista = new List<int>();
        for (int i = 0; i < 4; i++)
        {
            lista.Add(dice.Next(1, 7));
        }
        var soma = lista.OrderByDescending(q => q).Take(3).Sum();
        return soma;
    }
}
