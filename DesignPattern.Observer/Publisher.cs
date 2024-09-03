namespace DesignPattern.Observer;



public class Publisher : IPublisher
{
    // private readonly List<ISubscriber> _subscribers = [];

    private string _state;
    public event Notify? OnNotify;

    public void Subscribe(Notify subscriber)
    {
        Console.WriteLine("the subscriber has subscribed...");
        // _subscribers.Add(member);
        OnNotify += subscriber;
    }

    public void UnSubscribe(Notify subscriber)
    {
        Console.WriteLine("the subscriber has unsubscribed...");
        // _subscribers.Remove(member);
        OnNotify -= subscriber;
    }

    public void PublishPost(string state)
    {
        _state = state;
        Notify();
    }

    public void Notify()
    {
        OnNotify?.Invoke(_state);
        // foreach (var member in _subscribers)
        // {
        //     Console.WriteLine();
        //     // member.Update(_state);
        // }
    }
}