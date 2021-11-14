// See https://aka.ms/new-console-template for more information

var factoryA = new Factory.AFactory();
var factoryB = new Factory.BFactory();

var clientCodeA = new Factory.ClientCode();
var clientCodeB = new Factory.ClientCode();

clientCodeA.ExecuteClientCode(factoryA);
clientCodeB.ExecuteClientCode(factoryB);

clientCodeA.ExectueGenericClientCode();