using AbstractFactory;


    // The client code can work with any concrete factory class.
    Console.WriteLine("Client: Testing client code with the first factory type...");
    ClientMethod(new Factory1());
    Console.WriteLine();

    Console.WriteLine("Client: Testing the same client code with the second factory type...");
    ClientMethod(new Factory2());


void ClientMethod(IFactory factory)
{
    var productA = factory.CreateProductA();
    var productB = factory.CreateProductB();

    Console.WriteLine(productB.SomeFunction());
    Console.WriteLine(productB.SomeOtherFucntion(productA));
}