using Xunit;

public class QueueTests
{
    [Fact]
    public void Push_and_pop_are_first_in_last_out_order()
    {
        var deque = new QueueDeque<int>();
        deque.Enqueue(10);
        deque.Enqueue(20);
        Assert.Equal(10, deque.Dequeue());
        Assert.Equal(20, deque.Dequeue());
    }


    [Fact]
    public void Push_and_pop_can_handle_multiple_values()
    {
        var deque = new QueueDeque<int>();
        deque.Enqueue(10);
        deque.Enqueue(20);
        deque.Enqueue(30);
        Assert.Equal(10, deque.Dequeue());
        Assert.Equal(20, deque.Dequeue());
        Assert.Equal(30, deque.Dequeue());
    }

    [Fact]
    public void All_methods_of_manipulating_the_deque_can_be_used_together()
    {
        var deque = new QueueDeque<int>();
        deque.Enqueue(10);
        deque.Enqueue(20);
        Assert.Equal(10, deque.Dequeue());

        deque.Enqueue(30);
        Assert.Equal(20, deque.Dequeue());

        deque.Enqueue(40);
        deque.Enqueue(50);
        Assert.Equal(30, deque.Dequeue());
        Assert.Equal(40, deque.Dequeue());
        Assert.Equal(50, deque.Dequeue());
    }
}