namespace DesignPattern.Observer;
public delegate void Notify(string message);

public interface IPublisher
{
    event Notify OnNotify;
    void Subscribe(Notify subscriber);
    void UnSubscribe(Notify subscriber);
    void Notify();
}
