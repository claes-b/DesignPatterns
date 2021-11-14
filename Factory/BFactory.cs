namespace Factory;

public class BFactory : Factory
{
    public override IProduct Create() 
    {
        return new ProductB();
    }
}
