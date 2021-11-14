using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory;

public class ProductB2 : IProductB
{
    public string SomeFunction()
    {
        return "Product B2 Some function;";
    }

    public string SomeOtherFucntion(IProductA productA)
    {
        return $"Product B2 Some other function: {productA.SomeFunction()}";
    }
}
