public interface IAdatper
{
    string CompatibleMethod();
}

class SpecificClass
{
    public string SomeSpecificMethod()
    {
        return "Some specific stuff";
    }
}

class Adapter : IAdatper
{
    private readonly SpecificClass _adaptee;

    public Adapter(SpecificClass adaptee)
    {
        _adaptee = adaptee;
    }

    public string CompatibleMethod()
    {
        return _adaptee.SomeSpecificMethod();
    }
}

class Program
{
    static void Main(string[] args)
    {
        IAdatper target = new Adapter(new SpecificClass());
        Console.WriteLine(target.CompatibleMethod());
    }
}