using Builder;

var builder = new ComplexClassBuilder()
    .AddStringProperty("test123")
    .AddIntProperty(1337);

Console.WriteLine(builder.ComplexClass().ToString());

builder = new ComplexClassBuilder()
    .AddDoubleProperty(3)
    .SetBoolProperty(true);

Console.WriteLine(builder.ComplexClass().ToString());

var director = new ComplexClassDirector(builder);

director.BuildSmall();
Console.WriteLine(builder.ComplexClass().ToString());

director.BuildBig();
Console.WriteLine(builder.ComplexClass().ToString());