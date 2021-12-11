namespace Decorator;

public class ConcreteDecoratorB : BaseDecorator
{
    public ConcreteDecoratorB(Component component) : base(component)
    {

    }

    public override string SomeOperation()
    {
        return $"Concrete decorator B wrapping: {base.SomeOperation()}";
    }
}
