namespace Prototype;

public abstract class Parent : IClone<Parent>
{
    public int Width { get; set; }
    public int Height { get; set; }

    public Parent()
    {

    }

    public Parent(Parent parent)
    {
        Width = parent.Width;
        Height = parent.Height;
    }

    public abstract Parent Clone();

    public abstract string ToString();
}
