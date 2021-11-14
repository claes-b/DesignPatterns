using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory;

public class ProductA1 : IProductA
{
    public string SomeFunction()
    {
        return "Product A1 Some function";
    }
}
