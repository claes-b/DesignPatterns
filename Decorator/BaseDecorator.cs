namespace Decorator;

public abstract class BaseDecorator : Component
{
    protected Component _component;

    public BaseDecorator(Component component)
    {
        _component = component;
    }

    public void SetComponent(Component component)
    {
        this._component = component;
    }

    public override string SomeOperation()
    {
        if (this._component != null)
        {
            return _component.SomeOperation();
        }
        else
        {
            return string.Empty;
        }
    }
}