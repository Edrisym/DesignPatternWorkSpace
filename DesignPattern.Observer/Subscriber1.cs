namespace DesignPattern.Observer;

public class Subscriber1 : ISubscriber
{
    private string _state;

    public void Update(string state)
    {
        _state = state;
        GetNotify();
    }

    private void GetNotify()
    {
        Console.WriteLine($"Subscriber1 was notified - {_state}");
    }
}