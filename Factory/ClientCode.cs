namespace Factory;

public class ClientCode
{
    public void ExecuteClientCode(Factory factory)
    {
        IProduct product = factory.Create();
        Console.WriteLine(product.GetSomething());
    }

    public void ExectueGenericClientCode()
    {
        var factoryA = new GenericFactory<ProductA>();
        var factoryB = new GenericFactory<ProductB>();
        var productA = factoryA.Create();
        var productB = factoryB.Create();
        Console.WriteLine(productA.GetSomething());
        Console.WriteLine(productB.GetSomething());
    }
}
