namespace DesignPattern.Observer;

// The Subject
public interface IPublisher
{
    void Subscribe(ISubscriber subscriber);
    void UnSubscribe(ISubscriber subscriber);
    void Notify();
}
