namespace DesignPattern.Proxy;

public class ConcreteObject(string user) : RealObject
{
    private readonly string _user = user;

    public override string GetText()
    {
        return $"This text is from the concrete class for registered users {_user}";
    }
}