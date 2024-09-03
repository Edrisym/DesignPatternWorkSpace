using DesignPattern.Observer;

var publisher = new Publisher();

var subscriber1 = new Subscriber1();
var subscriber2 = new Subscriber2();

    publisher.Subscribe(subscriber1.Update);
    publisher.Subscribe(subscriber2.Update);

    // publisher.OnNotify += subscriber1.Update;
    // publisher.OnNotify += subscriber2.Update;

    //
    publisher.PublishPost("New post published!!");
    //
    publisher.UnSubscribe(subscriber1.Update);
    // // publisher.OnNotify -= subscriber1.Update;
    publisher.PublishPost("Another post published!!");