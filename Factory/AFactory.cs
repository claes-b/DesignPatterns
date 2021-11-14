namespace Factory;

public class AFactory : Factory
{
    public override IProduct Create()
    {
        return new ProductA();
    }
}
