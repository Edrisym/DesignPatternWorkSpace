namespace DesignPattern.Observer;

public class Subscriber2 : ISubscriber
{
    private string _state;

    public void Update(string state)
    {
        _state = state;
        GetNotify();
    }

    private void GetNotify()
    {
        Console.WriteLine($"Subscriber 2 was notified - {_state}");
    }
}