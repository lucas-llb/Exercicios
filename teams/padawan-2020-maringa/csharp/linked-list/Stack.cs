using System;
using System.Collections.Generic;

public class StackDeque<T>
{
    public Deque<T> Lista { get; set; }
    public StackDeque()
    {
        Lista = new Deque<T>();
    }
    public void Push(T value)
    {
        Lista.Push(value);
    }


    public T Pop()
    {
        return Lista.Pop();

    }
}