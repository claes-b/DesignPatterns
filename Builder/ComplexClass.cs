using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder;

public class ComplexClass
{
    public int IntProperty { get; set; }
    public string? StringProperty { get; set; }
    public bool BoolProperty { get; set; }
    public List<string>? ListProperty { get; set; }
    public double DoubleProperty { get; set; }

    public override string ToString()
    {
        return $"Int: {IntProperty}, String: {StringProperty}, Bool: {BoolProperty}, Double: {DoubleProperty}";
    }
}
