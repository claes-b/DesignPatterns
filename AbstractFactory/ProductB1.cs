using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory;

public class ProductB1 : IProductB
{
    public string SomeFunction()
    {
        return "Product B1 Some function;";
    }

    public string SomeOtherFucntion(IProductA productA)
    {
        return $"Product B1 Some other function: {productA.SomeFunction()}";
    }
}
