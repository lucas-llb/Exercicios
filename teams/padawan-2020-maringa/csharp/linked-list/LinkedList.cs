using System;
using System.Collections.Generic;

public class Lista<T>
{
    public T Valor{ get; set; }
    public Lista<T> Proximo { get; set; }
    public Lista<T> Anterior { get; set; }
}
public class Deque<T>
{

    //public List<T> Lista { get;  set; } = new List<T>();

    private Lista<T> primeiro;
    public void Push(T value)
    {
        if(primeiro is null)
        {
            primeiro = new Lista<T> { Valor = value };
            return;
        }
        Lista<T> ultimo = primeiro;
        while(!(ultimo.Proximo is null))
        {
            ultimo = primeiro.Proximo;
        }
        ultimo.Proximo = new Lista<T> { Valor = value, Anterior = ultimo };
    }

    public T Pop()
    {
        Lista<T> ultimo = primeiro;
        while(!(ultimo.Proximo is null))
        {
            ultimo = ultimo.Proximo;
        }
        T pop = ultimo.Valor;
        ultimo.Valor = default(T);
        if (!(ultimo.Anterior is null))
        {
            ultimo.Anterior.Proximo = null;
            return pop;
        }
        else
        {
            primeiro.Valor = default(T);
        }
        return pop;



        //if (Lista.Count > 0)
        //{
        //    T valor= default(T);
        //    for(int i=0; i<Lista.Count; i++)
        //    {
        //        if (i == (Lista.Count-1))
        //        {
        //            valor = Lista[i];
        //            Lista.RemoveAt(i);
        //        }
        //    }

        //    return valor;
        //}
        //else
        //{
        //    throw new ArgumentException();
        //}
    }

    public void Unshift(T value)
    {
        //Lista.Insert(0, value);
        if (primeiro is null)
        {
            primeiro = new Lista<T> { Valor = value };
            return;
        }
        Lista<T> segundo = primeiro;
        primeiro = new Lista<T> { Valor = value, Proximo = segundo };
        segundo.Anterior = primeiro;
        
    }

    public T Shift()
    {
        if(primeiro.Proximo is null)
        {
            T last = primeiro.Valor;
            primeiro.Valor = default(T);
            return last;
        }
        Lista<T> segundo = primeiro.Proximo;
        T shift = primeiro.Valor;
        primeiro = segundo;
        primeiro.Anterior = null;
        return shift;

        //if (Lista.Count > 0)
        //{
        //    T valor = default(T);
        //    for (int i = 0; i < Lista.Count; i++)
        //    {
        //        if (i == 0)
        //        {
        //            valor = Lista[i];
        //            Lista.RemoveAt(i);
        //        }
        //    }
        //    return valor;
        //}
        //else
        //{
        //    throw new ArgumentException();
        //}
    }
}