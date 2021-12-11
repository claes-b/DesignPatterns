using Decorator;

var c = new Client();

var simpleComponent = new ConcreteComponent();
Console.WriteLine("Executing client code with regular component");
c.ExecuteClientCode(simpleComponent);
Console.WriteLine("------------------------------");

var decoratedComponentA = new ConcreteDecoratorA(simpleComponent);
Console.WriteLine("Executing client code with decorated component");
c.ExecuteClientCode(decoratedComponentA);
Console.WriteLine("------------------------------");

var decoratedComponentB = new ConcreteDecoratorB(decoratedComponentA);
Console.WriteLine("Executing client code with twice decordated component");
c.ExecuteClientCode(decoratedComponentB);
Console.WriteLine("------------------------------");

public class Client
{
    public void ExecuteClientCode(Component component)
    {
        Console.WriteLine($"Client executed: {component.SomeOperation()}");
    }
}


