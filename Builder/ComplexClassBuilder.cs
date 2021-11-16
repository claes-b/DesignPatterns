using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder;

public class ComplexClassBuilder : IComplexClassBuilder
{
    private ComplexClass _complexClass;

    public ComplexClassBuilder() => Reset();

    public void Reset()
    {
        _complexClass = new ComplexClass();
    }

    public ComplexClassBuilder AddIntProperty(int i)
    {
        _complexClass.IntProperty = i;
        return this;
    }

    public ComplexClassBuilder AddStringProperty(string s)
    {
        _complexClass.StringProperty = s;
        return this;
    }

    public ComplexClassBuilder AddDoubleProperty(double d)
    {
        _complexClass.DoubleProperty = d;
        return this;
    }

    public ComplexClassBuilder SetBoolProperty(bool b)
    {
        _complexClass.BoolProperty = b;
        return this;
    }

    public ComplexClassBuilder InitList(List<string> l)
    {
        _complexClass.ListProperty = l;
        return this;
    }

    public ComplexClass ComplexClass() =>  _complexClass;
}
