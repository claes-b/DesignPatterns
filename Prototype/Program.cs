using Prototype;

var childOne = new ChildOne()
{
    Width = 3,
    Height = 3,
    Depth = 5
};

var childOneCopy = childOne.Clone();

var childTwo = new ChildTwo() { Height = 3, Width = 3, Size = 2 };

var childTwoCopy = childTwo.Clone();

var parents = new List<Parent>();
parents.Add(childOne);
parents.Add(childTwo);
parents.Add(childTwoCopy);
parents.Add(childOneCopy);

foreach (var parent in parents)
{
    Console.WriteLine(parent.ToString());
}

// Note: C# Has a cheat method to shallow clone objects, check it out below:
Console.WriteLine(childOne.ShallowClone().ToString());


