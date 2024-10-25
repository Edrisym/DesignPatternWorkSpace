namespace DesignPattern.Proxy;

public class Proxy(string currentUser) : RealObject
{
    private RealObject _obj;
    private readonly List<string> _registeredUser = new() { "Admin", "Owner" };
    private readonly string _currentUser = currentUser;

    public override string GetObject()
    {
        Console.WriteLine("Proxy call happening now...");
        Console.WriteLine("{0} wants to invoke a proxy method.", _currentUser);

        if (!_registeredUser.Contains(_currentUser))
            return $"Sorry {_currentUser}, you do not have access.";

        if (_obj is null)
        {
            _obj = new ConcreteObject(_currentUser);
        }

        return _obj.GetObject();
    }
}