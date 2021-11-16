using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder;

public class ComplexClassDirector
{
    private IComplexClassBuilder _builder;

    public ComplexClassDirector(IComplexClassBuilder builder)
    {
        _builder = builder;
    }

    public void BuildSmall()
    {
        _builder.Reset();
        _builder.AddDoubleProperty(1);
    }

    public void BuildBig()
    {
        _builder.Reset();
        _builder.AddIntProperty(123123);
        _builder.AddStringProperty("okapwodkqpwoke");
        _builder.AddDoubleProperty(120123123);
        _builder.SetBoolProperty(true);
    }
}
