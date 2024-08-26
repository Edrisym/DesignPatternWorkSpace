namespace DesignPattern.Observer;


public class Publisher : IPublisher
{
    private readonly List<ISubscriber> _subscribers = [];

    private string _state; // Can be anything that happens or gets updated

    public void Subscribe(ISubscriber member)
    {
        Console.WriteLine("the subscriber has subscribed...");
        _subscribers.Add(member);
    }

    public void UnSubscribe(ISubscriber member)
    {
        Console.WriteLine("the subscriber has unsubscribed...");
        _subscribers.Remove(member);
    }

    public void PublishPost(string state)
    {
        _state = state;
        Notify();
    }

    public void Notify()
    {
        foreach (var member in _subscribers)
        {
            member.Update(_state);
        }
    }
}