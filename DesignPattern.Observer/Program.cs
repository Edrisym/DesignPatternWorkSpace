using DesignPattern.Observer;

public class Program
{
    public static void Main()
    {
        var publisher = new Publisher();

        var subscriber1 = new Subscriber1();
        var subscriber2 = new Subscriber2();

        publisher.Subscribe(subscriber1);
        publisher.Subscribe(subscriber2);

        publisher.PublishPost("New post");

        publisher.UnSubscribe(subscriber1);

        publisher.PublishPost("New post");
    }
}