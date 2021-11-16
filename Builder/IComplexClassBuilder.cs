using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder;

public interface IComplexClassBuilder
{
    void Reset();
    ComplexClassBuilder AddIntProperty(int i);
    ComplexClassBuilder AddStringProperty(string s);
    ComplexClassBuilder AddDoubleProperty(double d);
    ComplexClassBuilder SetBoolProperty(bool b);
    ComplexClassBuilder InitList(List<string> l);
}
