namespace Prototype;

public class ChildOne : Parent
{
    public int Depth { get; set; }

    public ChildOne()
    {

    }

    public ChildOne(ChildOne source) : base(source)
    {
        Depth = source.Depth;
    }

    public override Parent Clone()
    {
        return new ChildOne(this);
    }

    public override string ToString()
    {
        return $"{Width}, {Height}, {Depth}";
    }

    public Parent ShallowClone()
    {
        return (Parent)this.MemberwiseClone();
    }
}
