namespace Decorator;

public class ConcreteDecoratorA : BaseDecorator
{
    public ConcreteDecoratorA(Component component) : base(component)
    {

    }

    public override string SomeOperation()
    {
        return $"Concrete decorator A wrapping: {base.SomeOperation()}";
    }
}