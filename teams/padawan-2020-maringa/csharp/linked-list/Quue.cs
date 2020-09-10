using System;
using System.Collections.Generic;

public class QueueDeque<T>
{
    public Deque<T> Lista { get; set; }
    public QueueDeque()
    {
        Lista = new Deque<T>();
    }
    public void Enqueue(T value)
    {
        Lista.Push(value);
    }


    public T Dequeue()
    {
        return Lista.Shift();

    }
}