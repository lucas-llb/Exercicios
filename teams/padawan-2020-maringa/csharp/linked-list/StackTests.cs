using Xunit;

public class StackTests
{
    [Fact]
    public void Push_and_pop_are_first_in_last_out_order()
    {
        var deque = new StackDeque<int>();
        deque.Push(10);
        deque.Push(20);
        Assert.Equal(20, deque.Pop());
        Assert.Equal(10, deque.Pop());
    }

    [Fact]
    public void Push_and_pop_can_handle_multiple_values()
    {
        var deque = new StackDeque<int>();
        deque.Push(10);
        deque.Push(20);
        deque.Push(30);
        Assert.Equal(30, deque.Pop());
        Assert.Equal(20, deque.Pop());
        Assert.Equal(10, deque.Pop());
    }

    [Fact]
    public void All_methods_of_manipulating_the_deque_can_be_used_together()
    {
        var deque = new StackDeque<int>();
        deque.Push(10);
        deque.Push(20);
        Assert.Equal(20, deque.Pop());

        deque.Push(30);
        Assert.Equal(30, deque.Pop());

        deque.Push(40);
        deque.Push(50);
        Assert.Equal(50, deque.Pop());
        Assert.Equal(40, deque.Pop());
        Assert.Equal(10, deque.Pop());
    }
}