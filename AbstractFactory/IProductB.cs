using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory;

public interface IProductB
{
    public string SomeFunction();
    public string SomeOtherFucntion(IProductA productA);
}
