using System;
using System.Collections.Generic;
using System.Linq;

public class Reactor
{
    public InputCell CreateInputCell(int value)
    {
        var celula = new InputCell();
        celula.Value = value;
        return celula;
    }

    public ComputeCell CreateComputeCell(IEnumerable<Cell> producers, Func<int[], int> compute)
    {
        var celula = new ComputeCell(producers, compute);
      
        return celula;   
    }
}

public abstract class Cell
{
    public int Value { get; set; }

    public EventHandler<int> Changed;
}


public class InputCell : Cell
{
}
    public class ComputeCell : Cell
    {
        public Func<int[], int> Compute { get; internal set; }
        public IEnumerable<Cell> Producers { get; internal set; }
        public ComputeCell(IEnumerable<Cell> producers, Func<int[], int> compute)
        {
            Compute = compute;
            Producers = producers;
        var lista = new List<int>();
            foreach (var cell in producers)
            {
              lista.Add(cell.Value);
            }
            
        void NewValue(object sender, int Value) => Value = compute.Invoke(lista.ToArray());
        foreach(var cell in producers)
        {
            cell.Changed += NewValue;
        }
        }
    } 

