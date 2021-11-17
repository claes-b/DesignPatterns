namespace Prototype;

public class ChildTwo : Parent
{
    public int Size { get; set; }

    public ChildTwo()
    {

    }

    public ChildTwo(ChildTwo source) : base(source)
    {
        Size = source.Size;
    }

    public override Parent Clone()
    {
        return new ChildTwo(this);
    }

    public override string ToString()
    {
        return $"{Width}, {Height}, {Size}";
    }
}
